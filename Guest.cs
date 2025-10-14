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

            //    comboBox1.DisplayMember = item;
            //    comboBox1.ValueMember = dic[item];


            //}
            DataTable dt = DB.SelectCol("select TypeID , Name from RoomType");
            DB.ComboBox(comboBox1, dt, "Name", "TypeID");
        


        }

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