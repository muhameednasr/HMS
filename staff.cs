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
        }

        private void staff_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtHotels = DB.Select("Hotel");
                DB.ComboBox(comboBoxHotel, dtHotels, "Name", "HotelID");
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxHotel.SelectedValue == null ||
                    string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    MessageBox.Show("Please fill all required fields.");
                    return;
                }

                DB.Command(
                    "INSERT INTO Staff (HotelID, FirstName, LastName, Position, Salary, DateOfBirth, Phone, Email, HireDate) " +
                    "VALUES (@hid, @fn, @ln, @pos, @sal, @dob, @ph, @em, @hd)",
                    new Dictionary<string, object>
                    {
                        {"@hid", Convert.ToInt32(comboBoxHotel.SelectedValue)},
                        {"@fn", txtFirstName.Text},
                        {"@ln", txtLastName.Text},
                        {"@pos", txtPosition.Text},
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
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

                DataGridViewRow row = dgvStaff.Rows[e.RowIndex];
                if (row.Cells["StaffID"].Value == null) return;

                int id = Convert.ToInt32(row.Cells["StaffID"].Value);
                string columnName = dgvStaff.Columns[e.ColumnIndex].Name;
                object newValue = row.Cells[e.ColumnIndex].Value ?? DBNull.Value;

                if (columnName.Equals("StaffID", StringComparison.OrdinalIgnoreCase)) return;

                string query = $"UPDATE Staff SET {columnName} = @val WHERE StaffID = @id";
                DB.Command(query, new Dictionary<string, object>
                {
                    {"@val", newValue},
                    {"@id", id}
                });

                row.DefaultCellStyle.BackColor = Color.LightGreen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating value: " + ex.Message);
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
            txtPosition.Clear();
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
