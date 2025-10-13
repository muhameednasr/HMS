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

        public Guest()
        {
            InitializeComponent();

            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
            dgv.EditMode = DataGridViewEditMode.EditOnEnter;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.CellValueChanged += dgv_CellValueChanged;
            dgv.CellClick += dgv_CellClick;
            dgv.MouseDown += dgv_MouseDown;
            dgv.SelectionChanged += dgv_SelectionChanged;

            txtFirstName.TextChanged += ValidateFirstName;
            txtLastName.TextChanged += ValidateLastName;
            txtEmail.TextChanged += ValidateEmail;
            txtPhone.TextChanged += ValidatePhone;
            dtpDateOfBirth.ValueChanged += ValidateAge;
            dgv.DataError += dgv_DataError;


            LoadRoomComboBox();
            LoadGuestData();

            if (dgv.Columns.Contains("DateOfBirth"))
                dgv.Columns["DateOfBirth"].DefaultCellStyle.Format = "dd/MM/yyyy";

            ClearInputs();

            this.Shown += (s, e) => { dgv.ClearSelection(); dgv.CurrentCell = null; };
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

            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add("GuestID", "Guest ID");
                dgv.Columns.Add("FirstName", "First Name");
                dgv.Columns.Add("LastName", "Last Name");
                dgv.Columns.Add("DateOfBirth", "Date of Birth");
                dgv.Columns.Add("Address", "Address");
                dgv.Columns.Add("Phone", "Phone");
                dgv.Columns.Add("Email", "Email");

                // ComboBox column
                DataGridViewComboBoxColumn roomColumn = new DataGridViewComboBoxColumn();
                roomColumn.Name = "room";
                roomColumn.HeaderText = "Room Number";
                dgv.Columns.Add(roomColumn);
            }

            //  RoomNumber Guest ( Booking)
            DataTable dtBookings = DB.SelectCol("SELECT GuestID, RoomNumber FROM Booking");

            foreach (DataRow dr in dtGuests.Rows)
            {
                string? roomNumber = dtBookings.AsEnumerable()
                    .Where(b => b["GuestID"] != DBNull.Value && Convert.ToInt32(b["GuestID"]) == Convert.ToInt32(dr["GuestID"]))
                    .Select(b => b["RoomNumber"].ToString())
                    .FirstOrDefault();

                dgv.Rows.Add(
                    dr["GuestID"],
                    dr["FirstName"],
                    dr["LastName"],
                    dr["DateOfBirth"],
                    dr["Address"],
                    dr["Phone"],
                    dr["Email"],
                    roomNumber ?? ""
                );
            }

            LoadRoomComboBoxInDGV();
        }

        private void LoadRoomComboBox()
        {
            try
            {
                DataTable dtRooms = DB.SelectCol("SELECT DISTINCT RoomNumber FROM Booking");
                DB.ComboBox(cmbRoom, dtRooms, "RoomNumber", "RoomNumber");
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
                DataTable dtRooms = DB.SelectCol("SELECT DISTINCT RoomNumber FROM Booking");
                DB.DGVComboBox(dgv, "room", dtRooms, "RoomNumber", "RoomNumber");
                ((DataGridViewComboBoxColumn)dgv.Columns["room"]).DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Room Numbers in DGV: {ex.Message}", "Error");
            }
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
            int atCount = email.Count(c => c == '@');
            int dotCount = email.Count(c => c == '.');
            
            bool isValid = atCount == 1 && dotCount == 1 &&
                           Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            emailInvalid.Visible = !isValid;
            emailInvalid.Text = !isValid ? "Invalid email" : "";
        }


        private void ValidatePhone(object? sender, EventArgs e)
        {
            string phoneDigits = new string(txtPhone.Text.Where(char.IsDigit).ToArray());
            phoneInvalid.Visible = phoneDigits.Length < 11;
            phoneInvalid.Text = phoneInvalid.Visible ? "Phone must be at leat 11 digits" : "";
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
            _selectedGuestId = null;
            dgv.ClearSelection();
            dgv.CurrentCell = null;

            fnameInvalid.Visible = false;
            LnameInvalid.Visible = false;
            emailInvalid.Visible = false;
            phoneInvalid.Visible = false;
        }

        // ---------------------- CRUD ----------------------

        private void Add_Click(object? sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

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

            DB.Command(
                "UPDATE Booking SET GuestID = (SELECT MAX(GuestID) FROM Guest) WHERE RoomNumber = @r",
                new Dictionary<string, object> { { "@r", cmbRoom.SelectedValue ?? DBNull.Value } });

            LoadGuestData();
            ClearInputs();
            MessageBox.Show("Guest added successfully!");
        }

        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            if (_selectedGuestId == null || !ValidateInputs()) return;

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

            DB.Command(
                "UPDATE Booking SET GuestID = @id WHERE RoomNumber = @r",
                new Dictionary<string, object>
                {
                    {"@id", _selectedGuestId},
                    {"@r", cmbRoom.SelectedValue ?? DBNull.Value}
                });

            LoadGuestData();
            MessageBox.Show("Guest updated successfully!");
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (_selectedGuestId == null)
            {
                MessageBox.Show("Please select a guest to delete.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DB.Command("DELETE FROM Guest WHERE GuestID=@id", new Dictionary<string, object> { { "@id", _selectedGuestId } });
                LoadGuestData();
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
            string roomNumber = row.Cells["room"].Value?.ToString() ?? "";

            DB.Command(
                "UPDATE Booking SET GuestID=@id WHERE RoomNumber=@room",
                new Dictionary<string, object> { { "@id", guestId }, { "@room", roomNumber } });
        }

        private void dgv_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgv.SelectedCells.Count == 0) { ClearInputs(); return; }

            var row = dgv.Rows[dgv.SelectedCells[0].RowIndex];
            if (row.Cells["GuestID"].Value == null) { ClearInputs(); return; }

            _selectedGuestId = Convert.ToInt32(row.Cells["GuestID"].Value);
            txtFirstName.Text = row.Cells["FirstName"].Value?.ToString() ?? "";
            txtLastName.Text = row.Cells["LastName"].Value?.ToString() ?? "";
            txtAddress.Text = row.Cells["Address"].Value?.ToString() ?? "";
            txtPhone.Text = row.Cells["Phone"].Value?.ToString() ?? "";
            txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";

            if (DateTime.TryParse(row.Cells["DateOfBirth"].Value?.ToString(), out DateTime dob))
                dtpDateOfBirth.Value = dob;

            cmbRoom.SelectedValue = row.Cells["room"].Value ?? -1;
        }

        private void dgv_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                dgv.Rows[e.RowIndex].Selected = true;
        }

        private void dgv_MouseDown(object? sender, MouseEventArgs e)
        {
            if (dgv.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.None)
                ClearInputs();
        }

        private void btnClear_Click(object? sender, EventArgs e) => ClearInputs();
        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            LoadGuestData();
            LoadRoomComboBox();
            ClearInputs();
        }

        private void Guest_Load(object? sender, EventArgs e) { }
        private void panel1_Paint(object? sender, PaintEventArgs e) { }
    }
}
