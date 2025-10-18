using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HMS
{
    public partial class staff : Form
    {
        private bool isCleared = false;

        public staff()
        {
            InitializeComponent();

            btnAdd.Click += btnAdd_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            btnReload.Click += btnReload_Click;
            this.Load += staff_Load;

            dgvStaff.CellValueChanged += dgvStaff_CellValueChanged;
            dgvStaff.UserDeletingRow += dgvStaff_UserDeletingRow;
            dgvStaff.CellValidating += dgvStaff_CellValidating;
        }

        private void staff_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtHotels = DB.Select("Hotel");
                DataTable dtStaff = DB.SelectCol("select distinct Position from Staff ");
                DB.ComboBox(comboBoxHotel, dtHotels, "Name", "HotelID");
                DB.ComboBox(comboPosition, dtStaff, "Position", "Position");
                LoadStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading data: " + ex.Message);
            }
        }

        private void LoadStaff()
        {
            try
            {
                DB.Load("Staff", dgvStaff);

                dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvStaff.ClearSelection();
                dgvStaff.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                dgvStaff.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
                dgvStaff.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                foreach (DataGridViewColumn col in dgvStaff.Columns)
                {
                    string name = col.Name.ToLower();

                    if (name == "staffid") col.HeaderText = "Staff ID";
                    else if (name == "hotelid") col.HeaderText = "Hotel";
                    else if (name == "firstname") col.HeaderText = "First Name";
                    else if (name == "lastname") col.HeaderText = "Last Name";
                    else if (name == "position") col.HeaderText = "Position";
                    else if (name == "salary") col.HeaderText = "Salary";
                    else if (name == "dateofbirth") col.HeaderText = "Birth Date";
                    else if (name == "phone") col.HeaderText = "Phone";
                    else if (name == "email") col.HeaderText = "Email";
                    else if (name == "hiredate") col.HeaderText = "Hire Date";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff data: " + ex.Message);
            }
        }
        private bool ValidateInputs()
        {
            if (comboBoxHotel.SelectedValue == null)
            {
                MessageBox.Show("Please select a hotel.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Validator.IsValidName(txtFirstName.Text))
            {
                MessageBox.Show("Please enter a valid first name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Validator.IsValidName(txtLastName.Text))
            {
                MessageBox.Show("Please enter a valid last name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Validator.IsValidName(comboPosition.ValueMember.ToString()))
            {
                MessageBox.Show("Please enter a valid position.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Validator.IsValidDecimal(txtSalary.Text))
            {
                MessageBox.Show("Please enter a valid salary.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Validator.IsOfAge(dtpBirth.Value))
            {
                MessageBox.Show("Staff member must be at least 18 years old.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Validator.IsValidPhone(txtPhone.Text))
            {
                MessageBox.Show("Please enter a valid phone number (at least 10 digits).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Validator.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs())
                {
                    return; // Stop the process if validation fails
                }

                DB.Command(
                    "INSERT INTO Staff (HotelID, FirstName, LastName, Position, Salary, DateOfBirth, Phone, Email, HireDate) " +
                    "VALUES (@hid, @fn, @ln, @pos, @sal, @dob, @ph, @em, @hd)",
                    new Dictionary<string, object>
                    {
                        {"@hid", Convert.ToInt32(comboBoxHotel.SelectedValue)},
                        {"@fn", txtFirstName.Text},
                        {"@ln", txtLastName.Text},
                        {"@pos", comboPosition.ValueMember.ToString()},
                        {"@sal", Convert.ToDecimal(txtSalary.Text)},
                        {"@dob", dtpBirth.Value},
                        {"@ph", txtPhone.Text},
                        {"@em", txtEmail.Text},
                        {"@hd", dtpHireDate.Value}
                    }
                );

                MessageBox.Show("Staff member added successfully!");
                LoadStaff();
                ClearInputs(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding staff: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStaff.CurrentRow == null)
                {
                    MessageBox.Show("Please select a staff member to delete.");
                    return;
                }

                int id = Convert.ToInt32(dgvStaff.CurrentRow.Cells["StaffID"].Value);

                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to delete this staff member?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    DB.Command("DELETE FROM Staff WHERE StaffID=@id",
                        new Dictionary<string, object> { { "@id", id } });

                    LoadStaff();
                    MessageBox.Show("Staff member deleted successfully!");
                    ClearInputs(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting: " + ex.Message);
            }
        }

        private void dgvStaff_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(e.Row.Cells["StaffID"].Value);
                DB.Command("DELETE FROM Staff WHERE StaffID=@id",
                    new Dictionary<string, object> { { "@id", id } });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting row: " + ex.Message);
            }
        }

        private void dgvStaff_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Validator.HandleCellValueChanged(dgvStaff, e, "Staff", "StaffID");
        }

        private void dgvStaff_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText = dgvStaff.Columns[e.ColumnIndex].HeaderText;
            string value = e.FormattedValue.ToString();
            bool isValid = true;
            string errorMessage = "";

            // Skip validation for new rows or if the value hasn't changed
            if (dgvStaff.Rows[e.RowIndex].IsNewRow || value == dgvStaff.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString())
            {
                return;
            }

            switch (headerText)
            {
                case "First Name":
                case "Last Name":
                case "Position":
                    isValid = Validator.IsValidName(value);
                    errorMessage = $"Please enter a valid {headerText}.";
                    break;
                case "Salary":
                    isValid = Validator.IsValidDecimal(value);
                    errorMessage = "Please enter a valid salary.";
                    break;
                case "Birth Date":
                    if (DateTime.TryParse(value, out DateTime dob))
                    {
                        isValid = Validator.IsOfAge(dob);
                        errorMessage = "Staff member must be at least 18 years old.";
                    }
                    else
                    {
                        isValid = false;
                        errorMessage = "Please enter a valid date format.";
                    }
                    break;
                case "Phone":
                    isValid = Validator.IsValidPhone(value);
                    errorMessage = "Please enter a valid phone number (at least 10 digits).";
                    break;
                case "Email":
                    isValid = Validator.IsValidEmail(value);
                    errorMessage = "Please enter a valid email address.";
                    break;
            }

            if (!isValid)
            {
                e.Cancel = true; // Prevents the user from leaving the invalid cell
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs(true);
        }

        private void ClearInputs(bool clearGrid)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtSalary.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            comboBoxHotel.SelectedIndex = -1;
            dtpBirth.Value = DateTime.Now;
            dtpHireDate.Value = DateTime.Now;

            if (clearGrid)
            {
                dgvStaff.Rows.Clear();
                isCleared = true;
            }

            dgvStaff.ClearSelection();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadStaff();
            dgvStaff.ClearSelection();
            MessageBox.Show("Staff list reloaded!");
        }
    }
}