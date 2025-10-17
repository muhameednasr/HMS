using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;  // ← مهم جدًا// عشان الطباعة
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HMS
{
    public partial class Booking_view : Form
    {
        PrintDocument printDocument = new PrintDocument();

        public Booking_view()
        {
            InitializeComponent();
            LoadBookings();
            printDocument.PrintPage += new PrintPageEventHandler(PrintBookingPage);
            dgvbooking.DataBindingComplete += dgvbooking_DataBindingComplete;
        }

        private void LoadBookings()
        {
            //dgvbooking.DataSource = DB.Select("Booking");
            string query = @"
                SELECT 
                    B.BookingID,
                    B.GuestID,
                      ISNULL(CONCAT(G.FirstName, ' ', G.LastName), 'Available') AS GuestName,
                    B.RoomNumber,
                    B.CheckinDate,
                    B.CheckoutDate,
                    B.TotalPrice
                FROM Booking AS B
                INNER JOIN Guest AS G ON B.GuestID = G.GuestID";

            DataTable dt = DB.SelectCol(query);
            dgvbooking.DataSource = dt;


        }

        private void label7_Click(object sender, EventArgs e)
        {
            AdminMain adminMain = new AdminMain();
            adminMain.Show();
            this.Close();
        }

        private void booking_schedulebtn_Click(object sender, EventArgs e)
        {
            try
            {
                // التأكد إن المستخدم اختار صف
                if (dgvbooking.SelectedRows.Count > 0)
                {
                    // قراءة BookingID و RoomID من الصف المحدد
                    int bookingId = Convert.ToInt32(dgvbooking.SelectedRows[0].Cells["BookingID"].Value);
                    int roomId = Convert.ToInt32(dgvbooking.SelectedRows[0].Cells["RoomNumber"].Value);

                    // تأكيد الحذف
                    DialogResult result = MessageBox.Show("Are you sure you want to Cancel this Booking?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    // 1️ حذف المدفوعات المرتبطة بالحجز
                    DB.Command("DELETE FROM Payment WHERE BookingID = @id",
                        new Dictionary<string, object> { { "@id", bookingId } });

                    // 2️ حذف الحجز نفسه
                    DB.Command("DELETE FROM Booking WHERE BookingID = @id",
                        new Dictionary<string, object> { { "@id", bookingId } });

                    // 3️ تحديث حالة الغرفة لتصبح "Available"
                    DB.Command("UPDATE Room SET Status = 'Available' WHERE RoomId = @roomId",
                        new Dictionary<string, object> { { "@roomId", roomId } });

                    // 4️ إعادة تحميل البيانات في الجدول
                    LoadBookings();

                    MessageBox.Show("Booking deleted Successfully");

                }
                else
                {
                    
                    MessageBox.Show("Please choose a row of Booking before Deleting.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went Error Since Delete Booking:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void booking_clearbtn_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    // العناوين
                    for (int i = 0; i < dgvbooking.Columns.Count; i++)
                    {
                        sw.Write(dgvbooking.Columns[i].HeaderText);
                        if (i < dgvbooking.Columns.Count - 1) sw.Write(",");
                    }
                    sw.WriteLine();

                    // البيانات
                    foreach (DataGridViewRow row in dgvbooking.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            for (int i = 0; i < dgvbooking.Columns.Count; i++)
                            {
                                sw.Write(row.Cells[i].Value?.ToString());
                                if (i < dgvbooking.Columns.Count - 1) sw.Write(",");
                            }
                            sw.WriteLine();
                        }
                    }
                }
                MessageBox.Show("Bookings exported successfully!");
            }
        }

        private void booking_boohkbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV files (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable dt = new DataTable();
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    string[] headers = sr.ReadLine().Split(',');
                    foreach (string header in headers)
                        dt.Columns.Add(header);

                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(',');
                        dt.Rows.Add(rows);
                    }
                }
                dgvBookingBackup.DataSource = dt;
            }
        }

        private void dgvbooking_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // لو العمود مش موجود، نضيفه
            if (!dgvbooking.Columns.Contains("DaysLeft"))
            {
                DataGridViewTextBoxColumn daysCol = new DataGridViewTextBoxColumn();
                daysCol.Name = "DaysLeft";
                daysCol.HeaderText = "DaysLeft";
                dgvbooking.Columns.Add(daysCol);
            }

            // نحسب الأيام المتبقية لكل صف
            foreach (DataGridViewRow row in dgvbooking.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["CheckoutDate"].Value != null && row.Cells["CheckoutDate"].Value != DBNull.Value)
                {
                    DateTime checkout = Convert.ToDateTime(row.Cells["CheckoutDate"].Value);
                    DateTime today = DateTime.Now;

                    int daysLeft = (checkout - today).Days;
                    row.Cells["DaysLeft"].Value = daysLeft;

                    if (daysLeft <= 2 && daysLeft >= 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else if (daysLeft < 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.Gray;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
                //else
                //{
                //    row.Cells["DaysLeft"].Value = "N/A";
                //}
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            string query = @"
               SELECT 
                B.BookingID,
                B.GuestID,
                ISNULL(CONCAT(G.FirstName, ' ', G.LastName), 'Available') AS GuestName,
                B.RoomNumber,
                B.CheckinDate,
                B.CheckoutDate,
                B.TotalPrice
                FROM Booking AS B
                LEFT JOIN Guest AS G ON B.GuestID = G.GuestID
                WHERE CONCAT(G.FirstName, ' ', G.LastName) LIKE @keyword
                   OR B.RoomNumber LIKE @keyword
                   OR B.BookingID LIKE @keyword";

            // لو الصندوق فاضي، نعرض كل الحجوزات
            if (string.IsNullOrEmpty(keyword))
            {
                LoadBookings(); // دالة تحميل البيانات الأصلية
            }
            else
            {
               
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(DB.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                dgvbooking.DataSource = dt;
            }
        }


        private void PrintBookingPage(object sender, PrintPageEventArgs e)
        {
            // إعدادات أولية
            Font font = new Font("Arial", 10);
            Brush brush = Brushes.Black;
            float y = 100;
            float x = 50;

            e.Graphics.DrawString("📋 Hotel Booking List", new Font("Arial", 16, FontStyle.Bold), brush, 250, y - 50);

            // عناوين الأعمدة
            for (int i = 0; i < dgvbooking.Columns.Count; i++)
            {
                e.Graphics.DrawString(dgvbooking.Columns[i].HeaderText, font, Brushes.Black, x + (i * 120), y);
            }

            y += 30;

            // طباعة كل الصفوف
            for (int r = 0; r < dgvbooking.Rows.Count; r++)
            {
                for (int c = 0; c < dgvbooking.Columns.Count; c++)
                {
                    var value = dgvbooking.Rows[r].Cells[c].Value;
                    e.Graphics.DrawString(value?.ToString(), font, brush, x + (c * 120), y);
                }

                y += 25;

                // لو الصفحة طويلة جدًا، نوقف ونكمل في الصفحة التالية
                if (y > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
        }

        private void booking_printbtn_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument;
            preview.ShowDialog();
        }
    }
}
