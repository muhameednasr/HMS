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

            string email = login_username.Text.Trim().Replace("'", "''");

            DataTable dt = DB.SelectCol($"SELECT * FROM Staff WHERE Email = '{email}'");

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("الإيميل غير موجود");
                return;
            }

            string role = dt.Rows[0]["Position"].ToString();



            if (role == "Admin")
            {
                AdminMain adminForm = new AdminMain();
                adminForm.Show();
                this.Hide();
            }
            //else
            //{
            //    UserDashboard userForm = new UserDashboard();
            //    userForm.Show();
            //}



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
