using Microsoft.Data.SqlClient;
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
        public static readonly string ConnectionString = "data source=. ; initial catalog= HMS; integrated security = true;TrustServerCertificate =True";

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
                Login login = new Login();
                login.Show();
                this.Close();
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

        private void Booking_btn_Click(object sender, EventArgs e)
        {
            admin_addUser addUser = new admin_addUser();
            addUser.Show();
        }

        private void rooms_btn_Click(object sender, EventArgs e)
        {
            admin_rooms rooms = new admin_rooms();
            rooms.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))

            {
                con.Open();

                // عدد الستاف
                string queryStaff = "SELECT COUNT(*) FROM Staff";
                using (SqlCommand cmd = new SqlCommand(queryStaff, con))
                {
                    int staffCount = (int)cmd.ExecuteScalar();
                    TotalStaff.Text = staffCount.ToString();
                }

                // الغرف المتاحة
                string queryRooms = "SELECT COUNT(*) FROM Room WHERE Status = 'Available'";
                using (SqlCommand cmd = new SqlCommand(queryRooms, con))
                {
                    int availableRooms = (int)cmd.ExecuteScalar();
                    AvailableRooms.Text = availableRooms.ToString();
                }

                // ربح اليوم
                string queryTodayProfit = @"SELECT ISNULL(SUM(TotalPrice), 0) 
                                    FROM Booking 
                                    WHERE CAST(CheckinDate AS DATE) = CAST(GETDATE() AS DATE)";
                using (SqlCommand cmd = new SqlCommand(queryTodayProfit, con))
                {
                    decimal todayProfit = (decimal)cmd.ExecuteScalar();
                    TodaysProfit.Text = todayProfit.ToString("C");
                }

                // إجمالي الربح
                string queryTotalProfit = "SELECT ISNULL(SUM(TotalPrice), 0) FROM Booking";
                using (SqlCommand cmd = new SqlCommand(queryTotalProfit, con))
                {
                    decimal totalProfit = (decimal)cmd.ExecuteScalar();
                    TotalProfit.Text = totalProfit.ToString("C");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guests_Booking guests_Booking = new Guests_Booking();
            guests_Booking.Show();
            this.Close();
        }

        private void TotalStaff_Click(object sender, EventArgs e)
        {

        }
    }
}