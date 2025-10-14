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
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exite?", "confirmation Message"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to logout?", "confirmation Message"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void addUser_btn_Click(object sender, EventArgs e)
        {
            admin_addUser addUser = new admin_addUser();
            addUser.Show();
        }

        private void rooms_btn_Click(object sender, EventArgs e)
        {
            admin_rooms rooms = new admin_rooms();
            rooms.Show();
        }

        private void guests_btn_Click(object sender, EventArgs e)
        {
            Guest guest = new Guest();
            guest.Show();
        }
    }
}
