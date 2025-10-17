using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HMS
{
    public partial class Hotel : Form
    {
        public Hotel()
        {
            InitializeComponent();
            DB.Load("Hotel", dgv);

            btnAdd.Click += btnAdd_Click;
            dgv.CellValueChanged += dgv_CellValueChanged;
            dgv.CellValidating += dgv_CellValidating;
        }

        private bool ValidateInputs()
        {
            if (!Validator.IsValidName(txtHotel.Text))
            {
                MessageBox.Show("Please enter a valid hotel name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAdress.Text))
            {
                MessageBox.Show("Address cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (!Validator.IsValidDecimal(txtStars.Text)) 
            {
                MessageBox.Show("Please enter a valid number for stars.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return; // Stop execution if validation fails
            }

            DB.Command(
              "INSERT INTO Hotel (Name, Address, Phone, Email, Stars) VALUES (@name, @address, @phone, @email, @stars)",
              new Dictionary<string, object>
              {
                  {"@name", txtHotel.Text},
                  {"@address", txtAdress.Text},
                  {"@phone", txtPhone.Text},
                  {"@email", txtEmail.Text},
                  {"@stars", int.Parse(txtStars.Text) }
              });

            DB.Load("Hotel", dgv); // Reload data to show the new entry
            MessageBox.Show("Hotel added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Use the centralized handler from the Validator class
            Validator.HandleCellValueChanged(dgv, e, "Hotel", "HotelId");
        }

        private void dgv_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText = dgv.Columns[e.ColumnIndex].HeaderText;
            string value = e.FormattedValue.ToString();
            bool isValid = true;
            string errorMessage = "";

            // Skip validation if the value hasn't changed
            if (dgv.Rows[e.RowIndex].IsNewRow || value == dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString())
            {
                return;
            }

            switch (headerText)
            {
                case "Hotel":
                    isValid = Validator.IsValidName(value);
                    errorMessage = "Please enter a valid hotel name.";
                    break;
                case "Address":
                    isValid = !string.IsNullOrWhiteSpace(value);
                    errorMessage = "Address cannot be empty.";
                    break;
                case "Phone":
                    isValid = Validator.IsValidPhone(value);
                    errorMessage = "Please enter a valid phone number (at least 10 digits).";
                    break;
                case "Email":
                    isValid = Validator.IsValidEmail(value);
                    errorMessage = "Please enter a valid email address.";
                    break;
                case "Stars":
                    isValid = Validator.IsValidDecimal(value);
                    errorMessage = "Please enter a valid number for stars.";
                    break;
            }

            if (!isValid)
            {
                e.Cancel = true; // Prevents the user from leaving the invalid cell
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null)
            {
                MessageBox.Show("Please select a hotel to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the ID of the selected hotel
            int hotelId = Convert.ToInt32(dgv.CurrentRow.Cells["HotelId"].Value);

            // Confirm the deletion
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this hotel?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    DB.Command("DELETE FROM Hotel WHERE HotelId = @id",
                        new Dictionary<string, object> { { "@id", hotelId } });

                    // reload the grid 
                    DB.Load("Hotel", dgv);

                    MessageBox.Show("Hotel deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error. The hotel might be in use by staff or rooms.\n" + ex.Message, "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}