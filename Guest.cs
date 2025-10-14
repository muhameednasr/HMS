using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace HMS
{
    public partial class Guest : Form
    {
        private int? _selectedGuestId = null;
        private int? _selectedBookingId = null;
        private int? _currentRoomNumber = null;

        public Guest()
        {
            InitializeComponent();

            // --- Setup DGV  ---
            SetupDataGridView();

            // --- Event Handlers ---
            dgv.CellValueChanged += dgv_CellValueChanged;
            dgv.CellClick += dgv_CellClick;
            dgv.MouseDown += dgv_MouseDown;
            dgv.SelectionChanged += dgv_SelectionChanged;
            dgv.DataError += dgv_DataError;

            txtFirstName.TextChanged += ValidateFirstName;
            txtLastName.TextChanged += ValidateLastName;
            txtEmail.TextChanged += ValidateEmail;
            txtPhone.TextChanged += ValidatePhone;
            dtpDateOfBirth.ValueChanged += ValidateAge;


            // --- Add Search Event Handlers ---
            txtSearch.TextChanged += txtSearch_TextChanged;
            btnClearSearch.Click += btnClearSearch_Click;

            this.Shown += (s, e) => { dgv.ClearSelection(); dgv.CurrentCell = null; };

            // --- Initial Load ---
            LoadRoomComboBox();
            LoadGuestData();
            ClearInputs();
        }

        private void SetupDataGridView()
        {
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Changed for better UX
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
            dgv.EditMode = DataGridViewEditMode.EditOnEnter;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoGenerateColumns = false;
            dgv.ColumnHeadersHeight = 50;

            // generate columns and define them.
            dgv.Columns.Clear();

            dgv.Columns.Add("GuestID", "Guest ID");
            dgv.Columns.Add("BookingID", "Booking ID");
            dgv.Columns.Add("FirstName", "First Name");
            dgv.Columns.Add("LastName", "Last Name");
            dgv.Columns.Add("DateOfBirth", "Date of Birth");
            dgv.Columns.Add("Address", "Address");
            dgv.Columns.Add("Phone", "Phone");
            dgv.Columns.Add("Email", "Email");

            // ComboBox column for Room
            DataGridViewComboBoxColumn roomColumn = new DataGridViewComboBoxColumn
            {
                Name = "room",
                HeaderText = "Room"
            };
            dgv.Columns.Add(roomColumn);

            // properties for specific columns
            dgv.Columns["BookingID"].Visible = false;
            dgv.Columns["GuestID"].ReadOnly = true;
            dgv.Columns["DateOfBirth"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void dgv_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        // ---------------------- Load Data ----------------------

        private void LoadGuestData()
        {
            dgv.Rows.Clear();
            DataTable dtGuests = DB.Select("Guest");

            // the latest booking for each guest
            DataTable dtBookings = DB.SelectCol(@"
                SELECT b1.BookingID, b1.GuestID, b1.RoomNumber 
                FROM Booking b1
                INNER JOIN (
                    SELECT GuestID, MAX(BookingID) as MaxBookingID
                    FROM Booking
                    GROUP BY GuestID
                ) b2 ON b1.BookingID = b2.MaxBookingID
            ");

            foreach (DataRow dr in dtGuests.Rows)
            {
                int guestId = Convert.ToInt32(dr["GuestID"]);

                var bookingRow = dtBookings.AsEnumerable()
                    .FirstOrDefault(b => b["GuestID"] != DBNull.Value && Convert.ToInt32(b["GuestID"]) == guestId);

                string? roomNumber = bookingRow?["RoomNumber"]?.ToString() ?? "";
                int? bookingId = bookingRow != null ? Convert.ToInt32(bookingRow["BookingID"]) : (int?)null;

                dgv.Rows.Add(
                    dr["GuestID"],
                    bookingId,
                    dr["FirstName"],
                    dr["LastName"],
                    dr["DateOfBirth"],
                    dr["Address"],
                    dr["Phone"],
                    dr["Email"],
                    roomNumber
                );
            }

            LoadRoomComboBoxInDGV();
        }

        private void LoadRoomComboBox()
        {
            try
            {
                //string query = "SELECT Room as RoomNumber FROM Room WHERE Status = 'Available'";
                //if (_currentRoomNumber != null)
                //{
                //    query += $" OR Room = {_currentRoomNumber}";
                //}
                //DataTable dtRoomsFromDb = DB.SelectCol(query);

                //DataTable dtComboSource = new DataTable();
                //dtComboSource.Columns.Add("Value", typeof(int));
                //dtComboSource.Columns.Add("Display", typeof(string));

                //dtComboSource.Rows.Add(-1, "select a room");

                //foreach (DataRow dr in dtRoomsFromDb.Rows)
                //{
                //    dtComboSource.Rows.Add(dr["RoomNumber"], dr["RoomNumber"].ToString());
                //}

                //DB.ComboBox(cmbRoom, dtComboSource, "Display", "Value");

                DataTable dtRoomNum = DB.SelectCol("select RoomId from Room r inner join Booking b on r.RoomId=b.RoomNumber where r.Status='Available';");

                DB.ComboBox(cmbRoom, dtRoomNum, "RoomId", "RoomId");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Room Numbers: {ex.Message}", "Error");
            }
        }

        private void LoadRoomComboBoxInDGV()
        {
            try
            {
                //DataTable dtRooms = DB.SelectCol(@"
                //    SELECT DISTINCT Room as RoomNumber 
                //    FROM Room 
                //    WHERE Status = 'Available' 
                //    OR Room IN (SELECT RoomNumber FROM Booking WHERE GuestID IN (SELECT GuestID FROM Guest))
                //");
                //DB.DGVComboBox(dgv, "Room", dtRooms, "RoomNumber", "RoomNumber");
                //((DataGridViewComboBoxColumn)dgv.Columns["room"]).DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
                DataTable dtRoomNum = DB.SelectCol("select RoomId from Room r inner join Booking b on r.RoomId=b.RoomNumber where r.Status='Available';");
                DB.DGVComboBox(dgv, "Room", dtRoomNum, "RoomId", "RoomId");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Room Numbers in DGV: {ex.Message}", "Error");
            }
        }

        // --- Search ---
        private void PerformSearch()
        {
            string searchText = txtSearch.Text?.Trim().ToLower() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadGuestData(); // if search box is empty, show all guests
                return;
            }

            dgv.Rows.Clear();
            DataTable dtGuests = DB.Select("Guest");
            DataTable dtBookings = DB.SelectCol(@"
                SELECT b1.BookingID, b1.GuestID, b1.RoomNumber 
                FROM Booking b1
                INNER JOIN (
                    SELECT GuestID, MAX(BookingID) as MaxBookingID
                    FROM Booking
                    GROUP BY GuestID
                ) b2 ON b1.BookingID = b2.MaxBookingID
            ");

            // LINQ join and filter data in memory
            var searchResults = from guest in dtGuests.AsEnumerable()
                                join booking in dtBookings.AsEnumerable()
                                on guest.Field<int>("GuestID") equals booking.Field<int>("GuestID") into gj
                                from b in gj.DefaultIfEmpty() // Left Outer Join to include guests without bookings
                                where
                                   (guest.Field<string>("FirstName")?.ToLower() ?? "").Contains(searchText) ||
                                   (guest.Field<string>("LastName")?.ToLower() ?? "").Contains(searchText) ||
                                   (guest.Field<string>("Email")?.ToLower() ?? "").Contains(searchText) ||
                                   (guest.Field<string>("Phone")?.ToLower() ?? "").Contains(searchText) ||
                                   (guest.Field<int?>("GuestID")?.ToString() ?? "").Contains(searchText)
                                select new
                                {
                                    GuestID = guest.Field<int>("GuestID"),
                                    BookingID = b?.Field<int?>("BookingID"),
                                    FirstName = guest.Field<string>("FirstName"),
                                    LastName = guest.Field<string>("LastName"),
                                    DateOfBirth = guest.Field<DateTime?>("DateOfBirth"),
                                    Address = guest.Field<string>("Address"),
                                    Phone = guest.Field<string>("Phone"),
                                    Email = guest.Field<string>("Email"),
                                    RoomNumber = b?.Field<int?>("RoomNumber")?.ToString() ?? ""
                                };

            foreach (var result in searchResults)
            {
                dgv.Rows.Add(
                    result.GuestID,
                    result.BookingID,
                    result.FirstName,
                    result.LastName,
                    result.DateOfBirth,
                    result.Address,
                    result.Phone,
                    result.Email,
                    result.RoomNumber
                );
            }

            LoadRoomComboBoxInDGV(); // Ensure DGV combo boxes are populated for filtered results
        }


        // ---------------------- Validation ----------------------

        private void ValidateFirstName(object? sender, EventArgs e)
        {
            fnameInvalid.Visible = string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                                     !Regex.IsMatch(txtFirstName.Text, @"^[\p{L}\s'-]+$") ||
                                     txtFirstName.Text.Length > 25;
            fnameInvalid.Text = fnameInvalid.Visible ? "Invalid First Name" : "";
        }

        private void ValidateLastName(object? sender, EventArgs e)
        {
            LnameInvalid.Visible = string.IsNullOrWhiteSpace(txtLastName.Text) ||
                                     !Regex.IsMatch(txtLastName.Text, @"^[\p{L}\s'-]+$") ||
                                     txtLastName.Text.Length > 25;
            LnameInvalid.Text = LnameInvalid.Visible ? "Invalid Last Name" : "";
        }

        private void ValidateEmail(object? sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            bool isValid = Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            emailInvalid.Visible = !isValid;
            emailInvalid.Text = !isValid ? "Invalid email" : "";
        }


        private void ValidatePhone(object? sender, EventArgs e)
        {
            string phoneDigits = new string(txtPhone.Text.Where(char.IsDigit).ToArray());
            phoneInvalid.Visible = phoneDigits.Length < 11;
            phoneInvalid.Text = phoneInvalid.Visible ? "Phone must be at least 11 digits" : "";
        }

        private void ValidateAge(object? sender, EventArgs e)
        {
            if (CalculateAge(dtpDateOfBirth.Value) < 18)
            {
                MessageBox.Show("Guest must be at least 18 years old.", "Validation Error");
            }
        }

        private int CalculateAge(DateTime birthDate)
        {
            int age = DateTime.Today.Year - birthDate.Year;
            if (birthDate > DateTime.Today.AddYears(-age)) age--;
            return age;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                cmbRoom.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required.", "Input Error");
                return false;
            }

            if (cmbRoom.SelectedIndex <= 0 || Convert.ToInt32(cmbRoom.SelectedValue) == -1)
            {
                MessageBox.Show("Please select a room.", "Input Error");
                return false;
            }

            if (CalculateAge(dtpDateOfBirth.Value) < 18)
            {
                MessageBox.Show("Guest must be at least 18 years old.", "Validation Error");
                return false;
            }

            if (fnameInvalid.Visible || LnameInvalid.Visible || emailInvalid.Visible || phoneInvalid.Visible)
            {
                MessageBox.Show("Please fix validation errors first.", "Validation Error");
                return false;
            }

            return true;
        }

        private void ClearInputs()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            cmbRoom.SelectedIndex = -1;
            // Set to placeholder value
            cmbRoom.SelectedValue = -1; 
            _selectedGuestId = null;
            _selectedBookingId = null;
            _currentRoomNumber = null;
            dgv.ClearSelection();
            dgv.CurrentCell = null;

            fnameInvalid.Visible = false;
            LnameInvalid.Visible = false;
            emailInvalid.Visible = false;
            phoneInvalid.Visible = false;

            LoadRoomComboBox();
        }

        // ---------------------- CRUD ----------------------

        private void Add_Click(object? sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            int selectedRoom = Convert.ToInt32(cmbRoom.SelectedValue);

            // Add Guest
            DB.Command(
                "INSERT INTO Guest (FirstName, LastName, DateOfBirth, Address, Phone, Email) VALUES (@f, @l, @d, @a, @p, @e)",
                new Dictionary<string, object>
                {
                    {"@f", txtFirstName.Text},
                    {"@l", txtLastName.Text},
                    {"@d", dtpDateOfBirth.Value.Date},
                    {"@a", txtAddress.Text},
                    {"@p", txtPhone.Text},
                    {"@e", txtEmail.Text}
                });

            // create a new booking for the guest
            DB.Command(
                "INSERT INTO Booking (GuestID, RoomNumber, CheckinDate, CheckoutDate, TotalPrice) VALUES ((SELECT MAX(GuestID) FROM Guest), @r, GETDATE(), DATEADD(day, 1, GETDATE()), 0)",
                new Dictionary<string, object> { { "@r", selectedRoom } });

            // update room status to occupied
            DB.Command(
                "UPDATE Room SET Status = 'Occupied' WHERE Room = @r",
                new Dictionary<string, object> { { "@r", selectedRoom } });

            LoadGuestData();
            LoadRoomComboBox();
            ClearInputs();
            MessageBox.Show("Guest added successfully!");
        }

        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            if (_selectedGuestId == null)
            {
                MessageBox.Show("Please select a guest to update.", "Selection Error");
                return;
            }
            if (!ValidateInputs()) return;

            int newRoom = Convert.ToInt32(cmbRoom.SelectedValue);

            // update Guest data
            DB.Command(
                "UPDATE Guest SET FirstName=@f, LastName=@l, DateOfBirth=@dob, Address=@a, Phone=@p, Email=@e WHERE GuestID=@id",
                new Dictionary<string, object>
                {
                    {"@id", _selectedGuestId},
                    {"@f", txtFirstName.Text},
                    {"@l", txtLastName.Text},
                    {"@dob", dtpDateOfBirth.Value.Date},
                    {"@a", txtAddress.Text},
                    {"@p", txtPhone.Text},
                    {"@e", txtEmail.Text}
                });

            // update booking (if exists)
            if (_selectedBookingId != null)
            {
                // if the room has changed
                if (_currentRoomNumber != newRoom)
                {
                    // make the old room available
                    if (_currentRoomNumber != null)
                    {
                        DB.Command(
                            "UPDATE Room SET Status = 'Available' WHERE Room = @oldRoom",
                            new Dictionary<string, object> { { "@oldRoom", _currentRoomNumber } });
                    }

                    // make the new room occupied
                    DB.Command(
                        "UPDATE Room SET Status = 'Occupied' WHERE Room = @newRoom",
                        new Dictionary<string, object> { { "@newRoom", newRoom } });
                }

                // update the room number in the booking
                DB.Command(
                    "UPDATE Booking SET RoomNumber = @r WHERE BookingID = @bid",
                    new Dictionary<string, object>
                    {
                        {"@bid", _selectedBookingId},
                        {"@r", newRoom}
                    });
            }
            else // create a new booking if one doesn't exist
            {
                DB.Command(
                    "INSERT INTO Booking (GuestID, RoomNumber, CheckinDate, CheckoutDate, TotalPrice) VALUES (@id, @r, GETDATE(), DATEADD(day, 1, GETDATE()), 0)",
                    new Dictionary<string, object>
                    {
                        {"@id", _selectedGuestId},
                        {"@r", newRoom}
                    });

                // make the new room occupied
                DB.Command(
                    "UPDATE Room SET Status = 'Occupied' WHERE Room = @r",
                    new Dictionary<string, object> { { "@r", newRoom } });
            }

            LoadGuestData();
            LoadRoomComboBox();
            ClearInputs();
            MessageBox.Show("Guest updated successfully!");
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (_selectedGuestId == null)
            {
                MessageBox.Show("Please select a guest to delete.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete? This will also delete all bookings for this guest.", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // get all rooms booked by this guest
                DataTable bookedRooms = DB.SelectCol($"SELECT RoomNumber FROM Booking WHERE GuestID = {_selectedGuestId}");

                // delete payments first to avoid foreign key constraints (if any)
                DB.Command("DELETE FROM Payment WHERE BookingID IN (SELECT BookingID FROM Booking WHERE GuestID=@id)", new Dictionary<string, object> { { "@id", _selectedGuestId } });

                // delete bookings
                DB.Command("DELETE FROM Booking WHERE GuestID=@id", new Dictionary<string, object> { { "@id", _selectedGuestId } });

                // delete Guest
                DB.Command("DELETE FROM Guest WHERE GuestID=@id", new Dictionary<string, object> { { "@id", _selectedGuestId } });

                // update room statuses to Available
                foreach (DataRow room in bookedRooms.Rows)
                {
                    DB.Command(
                        "UPDATE Room SET Status = 'Available' WHERE Room = @r",
                        new Dictionary<string, object> { { "@r", room["RoomNumber"] } });
                }

                LoadGuestData();
                LoadRoomComboBox();
                ClearInputs();
                MessageBox.Show("Guest deleted successfully!");
            }
        }

        // ---------------------- DGV Events ----------------------

        private void dgv_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgv.Columns[e.ColumnIndex].Name != "room") return;

            var row = dgv.Rows[e.RowIndex];
            if (row.Cells["GuestID"].Value == null) return;

            int guestId = Convert.ToInt32(row.Cells["GuestID"].Value);
            var bookingId = row.Cells["BookingID"].Value;
            string newRoomStr = row.Cells["room"].Value?.ToString() ?? "";

            if (string.IsNullOrEmpty(newRoomStr)) return;

            int newRoom = Convert.ToInt32(newRoomStr);

            // get the old room number
            int? oldRoom = null;
            if (bookingId != null && bookingId != DBNull.Value)
            {
                DataTable oldRoomData = DB.SelectCol($"SELECT RoomNumber FROM Booking WHERE BookingID = {bookingId}");
                if (oldRoomData.Rows.Count > 0 && oldRoomData.Rows[0]["RoomNumber"] != DBNull.Value)
                {
                    oldRoom = Convert.ToInt32(oldRoomData.Rows[0]["RoomNumber"]);
                }
            }

            if (bookingId != null && bookingId != DBNull.Value)
            {
                // if the room has changed
                if (oldRoom != null && oldRoom != newRoom)
                {
                    // Mmke the old room available
                    DB.Command(
                        "UPDATE Room SET Status = 'Available' WHERE Room = @oldRoom",
                        new Dictionary<string, object> { { "@oldRoom", oldRoom } });

                    // make the new room occupied
                    DB.Command(
                        "UPDATE Room SET Status = 'Occupied' WHERE Room = @newRoom",
                        new Dictionary<string, object> { { "@newRoom", newRoom } });
                }

                // update existing booking
                DB.Command(
                    "UPDATE Booking SET RoomNumber=@room WHERE BookingID=@bid",
                    new Dictionary<string, object> { { "@bid", bookingId }, { "@room", newRoom } });
            }
            else
            {
                // create a new booking
                DB.Command(
                    "INSERT INTO Booking (GuestID, RoomNumber, CheckinDate, CheckoutDate, TotalPrice) VALUES (@id, @room, GETDATE(), DATEADD(day, 1, GETDATE()), 0)",
                    new Dictionary<string, object> { { "@id", guestId }, { "@room", newRoom } });

                // make the new room Occupied
                DB.Command(
                    "UPDATE Room SET Status = 'Occupied' WHERE Room = @room",
                    new Dictionary<string, object> { { "@room", newRoom } });

                LoadGuestData(); // reload to get the new BookingID
            }

            LoadRoomComboBox(); // refresh all comboboxes
        }

        private void dgv_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                ClearInputs();
                return;
            }

            var row = dgv.SelectedRows[0];
            if (row.Cells["GuestID"].Value == null) { ClearInputs(); return; }

            _selectedGuestId = Convert.ToInt32(row.Cells["GuestID"].Value);

            var bookingIdValue = row.Cells["BookingID"].Value;
            _selectedBookingId = (bookingIdValue != null && bookingIdValue != DBNull.Value)
                ? Convert.ToInt32(bookingIdValue)
                : (int?)null;

            txtFirstName.Text = row.Cells["FirstName"].Value?.ToString() ?? "";
            txtLastName.Text = row.Cells["LastName"].Value?.ToString() ?? "";
            txtAddress.Text = row.Cells["Address"].Value?.ToString() ?? "";
            txtPhone.Text = row.Cells["Phone"].Value?.ToString() ?? "";
            txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";

            if (DateTime.TryParse(row.Cells["DateOfBirth"].Value?.ToString(), out DateTime dob))
                dtpDateOfBirth.Value = dob;

            var roomValue = row.Cells["room"].Value;
            if (roomValue != null && !string.IsNullOrEmpty(roomValue.ToString()))
            {
                _currentRoomNumber = Convert.ToInt32(roomValue);
                LoadRoomComboBox(); // reload the ComboBox to include the current room
                cmbRoom.SelectedValue = roomValue;
            }
            else
            {
                _currentRoomNumber = null;
                LoadRoomComboBox();
                cmbRoom.SelectedIndex = -1;
            }
        }

        private void dgv_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            // this is handled by SelectionChanged with FullRowSelect mode
        }

        private void dgv_MouseDown(object? sender, MouseEventArgs e)
        {
            if (dgv.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.None)
                ClearInputs();
        }

        private void btnClear_Click(object? sender, EventArgs e) => ClearInputs();
        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            txtSearch.Clear(); // clearing search triggers reload via TextChanged
            LoadGuestData();
            LoadRoomComboBox();
            ClearInputs();
        }

        private void Guest_Load(object? sender, EventArgs e) { }
        private void panel1_Paint(object? sender, PaintEventArgs e) { }

        // --- search Event Handlers ---
        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            PerformSearch();
        }

        private void btnClearSearch_Click(object? sender, EventArgs e)
        {
            txtSearch.Clear();
            // clearing the textbox automatically triggers txtSearch_TextChanged,
            // which calls PerformSearch() and reloads all data.
        }
    }
}