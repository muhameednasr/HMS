using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HMS
{
    public static class Validator
    {
        /// Validates that a string is a valid name (letters, spaces, hyphens, apostrophes).

        public static bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length > 50)
            {
                return false;
            }
            return Regex.IsMatch(name, @"^[\p{L}\s'-]+$");
        }


        /// Validates that a string is a well-formed email address.
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }
            return Regex.IsMatch(email.Trim(), @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$")
                   && !email.Contains("..")
                   && email.Count(c => c == '@') == 1;
        }


        /// Validates that a phone number contains at least 10 digits.
        public static bool IsValidPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                return false;
            }
            string phoneDigits = new string(phone.Where(char.IsDigit).ToArray());
            return phoneDigits.Length >= 10;
        }


        /// Validates that a string can be converted to a decimal.
        public static bool IsValidDecimal(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }
            return decimal.TryParse(input, out _);
        }


        /// Validates that a string can be converted to an integer.

        public static bool IsValidInt(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }
            return int.TryParse(input, out _);
        }

        /// Validates that a ComboBox has an item selected.
        public static bool IsComboBoxSelected(ComboBox comboBox)
        {
            return comboBox.SelectedIndex != -1;
        }


        /// Calculates the age based on a given birth date.
        public static int CalculateAge(DateTime birthDate)
        {
            int age = DateTime.Today.Year - birthDate.Year;
            if (birthDate.Date > DateTime.Today.AddYears(-age))
            {
                age--;
            }
            return age;
        }


        /// Checks if the calculated age is at or above a minimum required age.
        public static bool IsOfAge(DateTime birthDate, int minAge = 18)
        {
            return CalculateAge(birthDate) >= minAge;
        }

        /// Updates the visibility and text of a validation label based on a condition.
        public static void UpdateValidationLabel(Label label, bool isValid, string errorMessage)
        {
            label.Visible = !isValid;
            label.Text = isValid ? "" : errorMessage;
        }


        // stars for hotel
        public static bool IsValidStars(string input)
        {
            if (!int.TryParse(input, out int stars))
            {
                return false; 
            }
            return stars >= 1 && stars <= 7; 
        }

        /// Handles the CellValueChanged event for a DataGridView to update the database.
        public static void HandleCellValueChanged(DataGridView dgv, DataGridViewCellEventArgs e, string tableName, string primaryKeyColumnName)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

                DataGridViewRow row = dgv.Rows[e.RowIndex];
                if (row.Cells[primaryKeyColumnName].Value == null) return;

                int id = Convert.ToInt32(row.Cells[primaryKeyColumnName].Value);
                string columnName = dgv.Columns[e.ColumnIndex].Name;
                object newValue = row.Cells[e.ColumnIndex].Value ?? DBNull.Value;

                // Do not allow editing of the primary key
                if (columnName.Equals(primaryKeyColumnName, StringComparison.OrdinalIgnoreCase)) return;

                string query = $"UPDATE {tableName} SET {columnName} = @val WHERE {primaryKeyColumnName} = @id";
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
    }
}