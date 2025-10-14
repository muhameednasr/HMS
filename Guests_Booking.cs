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
using System.Drawing.Printing;  // ← مهم جدًا// عشان الطباعة


namespace HMS
{
    public partial class Guests_Booking : Form
    {
        bool roomsLoaded = false; // متغير لتتبع التحميل


        public Guests_Booking()
        {
            InitializeComponent();
            if (!roomsLoaded)
            {
                LoadAvailableRooms();// نحمل الغرف المتاحة أول ما الفورم يفتح
                roomsLoaded = true;// نغير الحالة عشان ما يتحملش تاني
            }
            LoadGuests();

        }
        // Back to AdminMain
        private void label7_Click(object sender, EventArgs e)
        {
            // العودة إلى AdminMain
            AdminMain adminMain = new AdminMain();
            adminMain.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        // DataGridView Cell Click Event Method //
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            // لو المستخدم اختار صف صالح
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // افترضي إن الأعمدة في الداتا جريد اسمها كالتالي:
                // RoomID, RoomType, HotelID, RoomStatus

                bookRoom_roomID.Text = row.Cells["RoomID"].Value.ToString();
                bookRoom_roomtype.Text = row.Cells["RoomTypeName"].Value.ToString();
                bookRoom_hotelID.Text = row.Cells["HotelName"].Value.ToString();
                bookRoom_roomStatus.Text = row.Cells["Status"].Value.ToString();
                txtPricePerNight.Text = row.Cells["PricePerNight"].Value?.ToString() ?? ""; //  مهم جدًا

                // نحسب السعر الكلي لو الأيام موجودة
                CalculateTotalPrice();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {


        }
        private void Guests_Booking_Load(object sender, EventArgs e)
        {

        }

        // Load Available Rooms Method 
        private void LoadAvailableRooms()
      {
            try
            {
                            string query = @"
                SELECT 
                    R.Room As RoomID,
                    H.Name AS HotelName,
                    R.Status,
                    R.TypeID,
                    RT.Name AS RoomTypeName,
                    RT.PricePerNight
                FROM Room R
                JOIN RoomType RT ON R.TypeID = RT.TypeID
                JOIN Hotel H ON R.HotelID = H.HotelID
                WHERE R.Status = 'Available'";


                using (SqlConnection con = new SqlConnection(DB.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
                    dataGridView1.DefaultCellStyle.BackColor = Color.White;
                    dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
                    dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;



                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("لا توجد غرف متاحة الآن.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rooms: " + ex.Message);
            }



        }

        // Calculate Total Price Method
        private void CalculateTotalPrice()
        {
            if (decimal.TryParse(txtPricePerNight.Text, out decimal pricePerNight) &&
         int.TryParse(txtDays.Text, out int days))
            {
                bookRoom_roomPrice.Text = (pricePerNight * days).ToString("0.00");
            }
            else
            {
                bookRoom_roomPrice.Text = "0.00";
            }
        }






        /////CalculateDays///////////////
        private void CalculateDays()
        {
            if (checkOutPicker.Value.Date > checkInPicker.Value.Date)
            {
                TimeSpan diff = checkOutPicker.Value.Date - checkInPicker.Value.Date;
                txtDays.Text = diff.Days.ToString();
            }
            else
            {
                txtDays.Text = "0";
            }
        }
        private void checkInPicker_ValueChanged(object sender, EventArgs e)
        {
            //CalculateDays();
        }

        private void checkOutPicker_ValueChanged(object sender, EventArgs e)
        {
            //CalculateDays();
        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void bookRoom_roomPrice_Click(object sender, EventArgs e)
        {

        }

        private void booking_shedulebtn_Click(object sender, EventArgs e)
        {
            if (checkOutPicker.Value > checkInPicker.Value)
            {
                TimeSpan diff = checkOutPicker.Value - checkInPicker.Value;
                txtDays.Text = diff.Days.ToString();

                CalculateTotalPrice(); // ← تضيفي دي عشان يحسب السعر الكلي تلقائيًا
            }
            else
            {
                MessageBox.Show("Checkout must be after Checkin at least one Day.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Clear Button Method
        private void booking_clearbtn_Click(object sender, EventArgs e)
        {
            bookRoom_roomID.Text = "__________";
            bookRoom_roomtype.Text = "__________";
            bookRoom_hotelID.Text = "__________";
            bookRoom_roomStatus.Text = "__________";
            txtPricePerNight.Text = "__________";
            txtDays.Text = "__________";
            bookRoom_roomPrice.Text = "__________";
        }

        // Booking Button Method
        private void booking_boohkbtn_Click(object sender, EventArgs e)
        {

            try
            {
                // التحقق إن كل البيانات الأساسية موجودة
                if (string.IsNullOrEmpty(bookRoom_roomID.Text) ||
                    string.IsNullOrEmpty(txtDays.Text) ||
                    string.IsNullOrEmpty(bookRoom_roomPrice.Text))
                {
                    MessageBox.Show("Please Complete all information before Booking.",
                                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = @"INSERT INTO Booking 
                 (GuestID, RoomNumber, CheckinDate, CheckoutDate, TotalPrice) 
                 VALUES (@GuestID, @RoomNumber, @CheckinDate, @CheckoutDate, @TotalPrice)";

                var parameters = new Dictionary<string, object>
                    {
                        {"@GuestID", booking_guestName.Text},  // خلي اسم النزيل هنا
                        {"@RoomNumber", bookRoom_roomID.Text},
                        {"@CheckinDate", checkInPicker.Value},
                        {"@CheckoutDate", checkOutPicker.Value},
                        {"@TotalPrice", bookRoom_roomPrice.Text},
                        //{"@Status", "Booked"}//////
                    };

                DB.Command(query, parameters);

                MessageBox.Show("The Room has been booked successfully",
                               "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // تحديث حالة الغرفة
                string updateRoom = "UPDATE Room SET Status = 'Booked', GuestID = @GuestID WHERE RoomNumber = @RoomNumber";
                DB.Command(updateRoom, new Dictionary<string, object>
                    {
                        { "@RoomNumber", bookRoom_roomID.Text },
                        {"@GuestID", booking_guestName.Text},  // خلي اسم النزيل هنا
                    });





                LoadAvailableRooms(); // عشان يحدث الجدول ويشيل الغرفة من المتاحة
                booking_clearbtn_Click(sender, e); // يمسح البيانات بعد الحجز
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went Error Since Booking: " + ex.Message);
            }

        }

        // Print Receipt Method
        private void PrintReceipt(object sender, PrintPageEventArgs e)
        {
            float y = 100;
            Font font = new Font("Arial", 12);
            e.Graphics.DrawString("Hotel Booking Receipt", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 100, y);
            y += 40;
            e.Graphics.DrawString($"Room ID: {bookRoom_roomID.Text}", font, Brushes.Black, 100, y);
            y += 25;
            e.Graphics.DrawString($"Room Type: {bookRoom_roomtype.Text}", font, Brushes.Black, 100, y);
            y += 25;
            e.Graphics.DrawString($"Hotel: {bookRoom_hotelID.Text}", font, Brushes.Black, 100, y);
            y += 25;
            e.Graphics.DrawString($"Check-in: {checkInPicker.Value.ToShortDateString()}", font, Brushes.Black, 100, y);
            y += 25;
            e.Graphics.DrawString($"Check-out: {checkOutPicker.Value.ToShortDateString()}", font, Brushes.Black, 100, y);
            y += 25;
            e.Graphics.DrawString($"Days: {txtDays.Text}", font, Brushes.Black, 100, y);
            y += 25;
            e.Graphics.DrawString($"Total Price: {bookRoom_roomPrice.Text} $", font, Brushes.Black, 100, y);
            y += 40;
            e.Graphics.DrawString("Thank you for choosing our hotel!", font, Brushes.Black, 100, y);
        }

        //Print Button//
        private void booking_printbtn_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(PrintReceipt);
            PrintPreviewDialog preview = new PrintPreviewDialog
            {
                Document = printDoc
            };
            preview.ShowDialog();
        }


        /////الجزء الخاص ب النزيل من الداتا جريد فيو/////
        ///
        private void LoadGuests()
        {
            try
            {
                string query = "SELECT GuestID, FirstName + ' ' + LastName AS FullName FROM Guest";

                using (SqlConnection con = new SqlConnection(DB.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvGuests.DataSource = dt;

                    // تحسين الشكل
                    dgvGuests.DefaultCellStyle.ForeColor = Color.Black;
                    dgvGuests.DefaultCellStyle.BackColor = Color.White;
                    dgvGuests.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
                    dgvGuests.DefaultCellStyle.SelectionForeColor = Color.Black;

                    dgvGuests.Columns["GuestID"].HeaderText = "ID";
                    dgvGuests.Columns["FullName"].HeaderText = "Guest Name";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading guests: " + ex.Message);
            }
        }

        // DataGridView Cell Click Event Method for Guests
        private void dgvGuests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGuests.Rows[e.RowIndex];
                string guestName = row.Cells["GuestID"].Value.ToString();
                booking_guestName.Text = guestName; // أو أي Label أو TextBox عندك
            }
        }
    }
}



