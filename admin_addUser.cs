using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class admin_addUser : Form
    {
        public admin_addUser()
        {
            InitializeComponent();
            LoadUsers();
        }
        // Load Users into DataGridView//
        private void LoadUsers()
        {

            string query = @"SELECT U.UserID, U.Username, U.Role, U.HotelID, U.StaffID
                     FROM Users U";

            DataTable dt = DB.SelectCol(query);
            dgvUsers.DataSource = dt;
            dgvUsers.AutoGenerateColumns = true;
        }



        private void admin_addUser_Load(object sender, EventArgs e)
        {

        }

        ///////////الجزء دا لسة متحددش هيتعمل ازاي ///////////
        private int GetSelectedStaffID()
        {
            if (addUser_role.SelectedValue != null)
                return Convert.ToInt32(addUser_role.SelectedValue);
            else
                throw new Exception("Must choose User");
        }


        // Back to Main Admin Page Click Event//
        private void label7_Click(object sender, EventArgs e)
        {
            AdminMain adminMain = new AdminMain();
            adminMain.Show();
            this.Close();
        }

        // Add Button Click Event//
        private void addUser_addbtn_Click_1(object sender, EventArgs e)
        {
            string username = addUser_username.Text.Trim();
            string password = addUser_password.Text.Trim(); // يفضل تشفريها قبل الحفظ لاحقاً
            string role = addUser_role.Text;
            if (!int.TryParse(addUser_hotelID.Text, out int hotelId))
            {
                MessageBox.Show("Choose a valid HotelID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(addUser_staffID.Text, out int staffId))
            {
                MessageBox.Show("Choose a valid StaffID .", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Fill Requiered Fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = @"INSERT INTO Users (HotelID, StaffID, Username, PasswordHash, Role)
                         VALUES (@HotelID, @StaffID, @Username, @Password, @Role)";

                var parameters = new Dictionary<string, object?>
        {
            {"@HotelID", hotelId},
            {"@StaffID", staffId},
            {"@Username", username},
            {"@Password", password}, // لاحقًا استبدليها بـ hashed password
            {"@Role", role}
        };

                DB.Command(query, parameters); // هذه الدالة موجودة في كلاس DB لديك

                MessageBox.Show("User  added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadUsers();      // تحديث الـ DataGridView لعرض المستخدمين الجدد
                ClearInputs();    // مسح الحقول (دالة سننشئها بعد قليل)
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went Error Since Adding: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Clear Input Fields//
        private void ClearInputs()
        {
            addUser_username.Clear();
            addUser_password.Clear();
            addUser_role.SelectedIndex = -1;
            addUser_hotelID.SelectedIndex = -1;
            addUser_staffID.SelectedIndex = -1;
            if (dgvUsers != null)
            {
                dgvUsers.ClearSelection();
                dgvUsers.CurrentCell = null;
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                addUser_username.Text = row.Cells["Username"].Value.ToString();
                //addUser_password.Text = row.Cells["PasswordHash"].Value.ToString();
                addUser_role.Text = row.Cells["Role"].Value.ToString();
                addUser_hotelID.Text = row.Cells["HotelID"].Value.ToString();
                addUser_staffID.Text = row.Cells["StaffID"].Value.ToString();
            }
        }

        // Clear Button Click Event//
        private void addUser_clearbtn_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        // Update Button Click Event//
        private void addUser_updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsers.CurrentRow == null)
                {
                    MessageBox.Show("Please choose User for Updating.");
                    return;
                }

                int userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value);
                string username = addUser_username.Text.Trim();
                string password = addUser_password.Text.Trim();
                string role = addUser_role.Text;

                if (!int.TryParse(addUser_hotelID.Text, out int hotelId) ||
                    !int.TryParse(addUser_staffID.Text, out int staffId))
                {
                    MessageBox.Show("Check valid in HotelID و StaffID.");
                    return;
                }
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Fill Requiered Fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = @"
            UPDATE Users
            SET Username = @Username,
                PasswordHash = @Password,
                Role = @Role,
                HotelID = @HotelID,
                StaffID = @StaffID
            WHERE UserID = @UserID";

                var parameters = new Dictionary<string, object?>
        {
            {"@Username", username},
            {"@Password", password},
            {"@Role", role},
            {"@HotelID", hotelId},
            {"@StaffID", staffId},
            {"@UserID", userId}
        };

                DB.Command(query, parameters);

                MessageBox.Show("Data Updated Successfully.");
                LoadUsers();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went Error Since Updating: " + ex.Message);
            }
        }

        // Delete Button Click Event//
        private void addUser_deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsers.CurrentRow == null)
                {
                    MessageBox.Show("Choose User for Deleting.");
                    return;
                }

                int userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value);

                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to delete this user?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    string query = "DELETE FROM Users WHERE UserID = @UserID";
                    var parameters = new Dictionary<string, object?>
            {
                {"@UserID", userId}
            };

                    DB.Command(query, parameters);

                    MessageBox.Show("User Deleted Successfully.");
                    LoadUsers();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went Error Since Deleting: " + ex.Message);
            }
        }
        private void dvg_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvUsers.Rows[e.RowIndex];

            var userID = row.Cells["UserID"].Value;
            var staffID = row.Cells["StaffID"].Value;
            var hotelID = row.Cells["HotelID"].Value;
            var username = row.Cells["Username"].Value;
            var passwordHash = row.Cells["PasswordHash"].Value;
            var role = row.Cells["Role"].Value;

            DB.Command(
                "UPDATE Users SET Role=@role,StaffID=@staffID, HotelID=@hotelID, Username=@username,PasswordHash=@passwordHash WHERE UserID=@userID",
                new Dictionary<string, object>
                {
            {"@UserID", userID},
            {"@StaffID", staffID},
            {"@HotelID", hotelID},
            {"@Username", username},
            {"@PasswordHash", passwordHash},
            {"@Role", role}
                }
            );
        }
    }
}