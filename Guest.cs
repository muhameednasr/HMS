using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HMS
{
    public partial class Guest : Form
    {
        private int? _selectedGuestId = null;

        public Guest()
        {
            InitializeComponent();
            SetupDataGridView();
            // dgv events 
            dgv.CellClick += dgv_CellClick;
            dgv.MouseDown += dgv_MouseDown;
            dgv.SelectionChanged += dgv_SelectionChanged;

            // Validation handlers now use the static Validator class
            txtFirstName.TextChanged +=
                (s, e) => Validator.UpdateValidationLabel
                (fnameInvalid, Validator.IsValidName(txtFirstName.Text), "Invalid First Name");
            txtLastName.TextChanged +=
                (s, e) => Validator.UpdateValidationLabel
                (LnameInvalid, Validator.IsValidName(txtLastName.Text), "Invalid Last Name");
            txtEmail.TextChanged += 
                (s, e) => Validator.UpdateValidationLabel
                (emailInvalid, Validator.IsValidEmail(txtEmail.Text), "Invalid email");
            txtPhone.TextChanged +=
                (s, e) => Validator.UpdateValidationLabel
                (phoneInvalid, Validator.IsValidPhone(txtPhone.Text), "Phone must be at least 11 digits");
        }

        // ---------------------- Load ----------------------
        private void Guest_Load(object sender, EventArgs e)
        {
            LoadGuestData();
            ClearInputs();
        }
        private void dgv_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            // handled by SelectionChanged
        }

        private void dgv_MouseDown(object? sender, MouseEventArgs e)
        {
            if (dgv.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.None)
                ClearInputs();
        }
        // ---------------------- DGV Setup ----------------------
        private void SetupDataGridView()
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
            dgv.AutoGenerateColumns = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Columns["GuestID"].ReadOnly = true;
            dgv.Columns["DateOfBirth"].DefaultCellStyle.Format = "dd/MM/yyyy";

            dgv.SelectionChanged += dgv_SelectionChanged;
            dgv.DataError += (s, e) => e.ThrowException = false;
        }

        // Helper wrapper that fills a DataGridView directly using DB.Select()
        private void Select(string tableName, DataGridView dgv)
        {
            dgv.Rows.Clear();
            DataTable dt = DB.Select(tableName);
            foreach (DataRow dr in dt.Rows)
            {
                dgv.Rows.Add(
                    dr["GuestID"],
                    dr["FirstName"],
                    dr["LastName"],
                    dr["DateOfBirth"],
                    dr["Address"],
                    dr["Phone"],
                    dr["Email"]
                );
            }
        }
        // ---------------------- Load Data ----------------------
        private void LoadGuestData()
        {
            Select("Guest", dgv);
        }

        // ---------------------- Search ----------------------
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string text = txtSearch.Text.Trim().ToLower();
            dgv.Rows.Clear();

            if (string.IsNullOrWhiteSpace(text))
            {
                LoadGuestData();
                return;
            }

            DataTable dt = DB.Select("Guest");
            var results = dt.AsEnumerable().Where(g =>
                (g["FirstName"]?.ToString()?.ToLower() ?? "").Contains(text) ||
                (g["LastName"]?.ToString()?.ToLower() ?? "").Contains(text) ||
                (g["Email"]?.ToString()?.ToLower() ?? "").Contains(text) ||
                (g["Phone"]?.ToString()?.ToLower() ?? "").Contains(text) ||
                (g["Address"]?.ToString()?.ToLower() ?? "").Contains(text)
            );

            foreach (var g in results)
            {
                dgv.Rows.Add(
                    g["GuestID"],
                    g["FirstName"],
                    g["LastName"],
                    g["DateOfBirth"],
                    g["Address"],
                    g["Phone"],
                    g["Email"]
                );
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        // ---------------------- Clear ----------------------
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            dtpDateOfBirth.Value = DateTime.Today;
            _selectedGuestId = null;
            dgv.ClearSelection();

            fnameInvalid.Visible = false;
            LnameInvalid.Visible = false;
            emailInvalid.Visible = false;
            phoneInvalid.Visible = false;
        }

        // ---------------------- CRUD ----------------------
        private void Add_Click(object? sender, EventArgs e)
        {
            if (!ValidateAllInputs()) return;

            DB.Command(
                "INSERT INTO Guest (FirstName, LastName, DateOfBirth, Address, Phone, Email) " +
                "VALUES (@f,@l,@d,@a,@p,@e)",
                new Dictionary<string, object>
                {
                    {"@f", txtFirstName.Text},
                    {"@l", txtLastName.Text},
                    {"@d", dtpDateOfBirth.Value.Date},
                    {"@a", txtAddress.Text},
                    {"@p", txtPhone.Text},
                    {"@e", txtEmail.Text}
                });

            LoadGuestData();
            ClearInputs();
            MessageBox.Show("Guest added successfully!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedGuestId == null)
            {
                MessageBox.Show("Please select a guest to update.");
                return;
            }
            if (!ValidateAllInputs()) return;

            DB.Command(
                "UPDATE Guest SET FirstName=@f, LastName=@l, DateOfBirth=@d, Address=@a, Phone=@p, Email=@e WHERE GuestID=@id",
                new Dictionary<string, object>
                {
                    {"@id", _selectedGuestId},
                    {"@f", txtFirstName.Text},
                    {"@l", txtLastName.Text},
                    {"@d", dtpDateOfBirth.Value.Date},
                    {"@a", txtAddress.Text},
                    {"@p", txtPhone.Text},
                    {"@e", txtEmail.Text}
                });

            LoadGuestData();
            ClearInputs();
            MessageBox.Show("Guest updated successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedGuestId == null)
            {
                MessageBox.Show("Select a guest to delete.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this guest?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DB.Command("DELETE FROM Guest WHERE GuestID=@id",
                    new Dictionary<string, object> { { "@id", _selectedGuestId } });

                LoadGuestData();
                ClearInputs();
                MessageBox.Show("Guest deleted successfully!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadGuestData();
            ClearInputs();
        }

        // ---------------------- DGV Events ----------------------
        private void dgv_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0) return;
            var row = dgv.SelectedRows[0];
            if (row.Cells["GuestID"].Value == null) return;

            _selectedGuestId = Convert.ToInt32(row.Cells["GuestID"].Value);
            txtFirstName.Text = row.Cells["FirstName"].Value?.ToString() ?? "";
            txtLastName.Text = row.Cells["LastName"].Value?.ToString() ?? "";
            txtAddress.Text = row.Cells["Address"].Value?.ToString() ?? "";
            txtPhone.Text = row.Cells["Phone"].Value?.ToString() ?? "";
            txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";

            if (DateTime.TryParse(row.Cells["DateOfBirth"].Value?.ToString(), out DateTime dob))
                dtpDateOfBirth.Value = dob;
        }

        // ---------------------- Validation ----------------------
        private bool ValidateAllInputs()
        {
            // Check for empty required fields
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("All fields are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check individual field formats using the Validator class
            if (!Validator.IsValidName(txtFirstName.Text) ||
                !Validator.IsValidName(txtLastName.Text) ||
                !Validator.IsValidEmail(txtEmail.Text) ||
                !Validator.IsValidPhone(txtPhone.Text))
            {
                MessageBox.Show("Please correct the highlighted fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check age constraint
            if (!Validator.IsOfAge(dtpDateOfBirth.Value))
            {
                MessageBox.Show("Guest must be at least 18 years old.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}
