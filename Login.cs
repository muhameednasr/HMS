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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            string userName = login_username.Text.Trim().Replace("'", "''");

            DataTable dt = DB.SelectCol($"SELECT * FROM Users WHERE Username = '{userName}'");


            string password = txtPassword.Text.Trim();


            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("there is no users found");
                return;
            }

            string role = dt.Rows[0]["Role"].ToString();
            string PassFromDb = dt.Rows[0]["PasswordHash"].ToString();
            DB.user = dt.Rows[0]["Username"].ToString();
            DB.role = dt.Rows[0]["Role"].ToString();



            if (role == "Admin" && PassFromDb==password || role== "Receptionist" && PassFromDb == password)
            {
                AdminMain adminForm = new AdminMain();
                adminForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("password or email is not correct");
                return;
            }



        }

        private void login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showpass.Checked) {
                txtPassword.PasswordChar = default;
            }
            else
            {
                
                txtPassword.PasswordChar='*';

            }
        }
    }
}
