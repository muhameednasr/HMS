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
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void admin_addUser_Load(object sender, EventArgs e)
        {

        }
        private void LoadUsers()
        {
            DataTable dt = DB.SelectCol("SELECT u.UserID, s.FirstName + ' ' + s.LastName AS StaffName, u.Username, u.Role FROM Users u JOIN Staff s ON u.StaffID = s.StaffID");
            dgvUsers.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                dgvUsers.Rows.Add(row["UserID"], row["StaffName"], row["Username"], row["Role"]);
            }
        }

        ///////////الجزء دا لسة متحددش هيتعمل ازاي ///////////
        private int GetSelectedStaffID()
        {
            if (addUser_role.SelectedValue != null)
                return Convert.ToInt32(addUser_role.SelectedValue);
            else
                throw new Exception("Must choose User");
        }
        private void addUser_addbtn_Click(object sender, EventArgs e)
        {
            string username = addUser_username.Text.Trim();
            string password = addUser_password.Text.Trim();
            string role = addUser_role.SelectedItem?.ToString();

            int staffId = GetSelectedStaffID(); 

            DB.Command("INSERT INTO Users (StaffID, Username, Password, Role) VALUES (@s, @u, @p, @r)",
                new Dictionary<string, object>
                {
            {"@s", staffId},
            {"@u", username},
            {"@p", password},
            {"@r", role}
                });

            MessageBox.Show("User Added Successfully");
            LoadUsers();

        }
    }
}
