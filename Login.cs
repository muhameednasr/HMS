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

            string username = login_username.Text.Trim();
            string password = login_password.Text.Trim(); // خلي بالك لازم يكون عندك TextBox للباسورد

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please Enter Username and Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(DB.ConnectionString))
                {
                    string query = @"
                SELECT 
                    U.Role, U.Username, 
                    S.FirstName + ' ' + S.LastName AS FullName,
                    H.Name AS HotelName
                FROM Users U
                JOIN Staff S ON U.StaffID = S.StaffID
                JOIN Hotel H ON U.HotelID = H.HotelID
                WHERE U.Username = @Username AND U.PasswordHash = @Password";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string role = reader["Role"].ToString();
                        string name = reader["FullName"].ToString();
                        string hotel = reader["HotelName"].ToString();

                        MessageBox.Show($"Welcome {name} at Hotel {hotel}", "Login Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // التفرقة بين الأدوار
                        if (role == "Admin")
                        {
                            AdminMain adminForm = new AdminMain();
                            adminForm.Show();
                        }
                        else if (role == "Receptionist")
                        {
                            Guests_Booking receptionForm = new Guests_Booking();
                            receptionForm.Show();
                        }

                        this.Hide(); // يخفي صفحة اللوجن بعد الدخول
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is invaled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went Wrong " + ex.Message);
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showpass.Checked)
            {
                // لو الشيك بوكس متعلم عليه → أظهر الباسورد
                login_password.UseSystemPasswordChar = false;
            }
            else
            {
                // لو اتشال التعليم → اخفي الباسورد
                login_password.UseSystemPasswordChar = true;
            }
        }
    }
}
