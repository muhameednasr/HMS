using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HMS
{
    public partial class Booking_view : Form
    {
        private PrintDocument printDocument = new PrintDocument();
        private DataTable _allBookingsTable;

        public Booking_view()
        {
            InitializeComponent();
            LoadBookings();
            printDocument.PrintPage += new PrintPageEventHandler(PrintBookingPage);
            dgvbooking.DataBindingComplete += dgvbooking_DataBindingComplete;
        }

        private void LoadBookings()
        {
            // Get all booking data from the database
            string query = @"
                SELECT 
                    B.BookingID, B.GuestID,
                    ISNULL(CONCAT(G.FirstName, ' ', G.LastName), 'N/A') AS GuestName,
                    B.RoomNumber, B.CheckinDate, B.CheckoutDate, B.TotalPrice
                FROM Booking AS B 
                LEFT JOIN Guest AS G ON B.GuestID = G.GuestID";

            _allBookingsTable = DB.SelectCol(query);

            //  calculate the DaysLeft column 
            if (!_allBookingsTable.Columns.Contains("DaysLeft"))
            {
                _allBookingsTable.Columns.Add("DaysLeft", typeof(int));
            }

            DateTime today = DateTime.Now.Date;
            foreach (DataRow row in _allBookingsTable.Rows)
            {
                if (row["CheckoutDate"] != DBNull.Value)
                {
                    DateTime checkout = Convert.ToDateTime(row["CheckoutDate"]);
                    row["DaysLeft"] = (checkout - today).Days;
                }
            }

            // 3. Bind the complete, prepared data to the DataGridView
            dgvbooking.DataSource = _allBookingsTable;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            // If search box is empty, show original data
            if (string.IsNullOrEmpty(keyword))
            {
                dgvbooking.DataSource = _allBookingsTable;
                return;
            }

            // Filter DataTable using LINQ
            var results = _allBookingsTable.AsEnumerable().Where(row =>
                (row["GuestName"]?.ToString()?.ToLower() ?? "").Contains(keyword) ||
                (row["RoomNumber"]?.ToString()?.ToLower() ?? "").Contains(keyword)

             
            );

            // Display the filtered results
            if (results.Any())
            {
                dgvbooking.DataSource = results.CopyToDataTable();
            }
            else
            {
                // Show an empty grid with  by using a clone of the original table
                dgvbooking.DataSource = _allBookingsTable.Clone();
            }
        }

        private void dgvbooking_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // function color the rows based on the existing DaysLeft value
            foreach (DataGridViewRow row in dgvbooking.Rows)
            {
                if (row.IsNewRow || row.Cells["DaysLeft"].Value == null || row.Cells["DaysLeft"].Value == DBNull.Value) continue;

                int daysLeft = Convert.ToInt32(row.Cells["DaysLeft"].Value);

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
                if (dgvbooking.SelectedRows.Count > 0)
                {
                    int bookingId = Convert.ToInt32(dgvbooking.SelectedRows[0].Cells["BookingID"].Value);
                    int roomId = Convert.ToInt32(dgvbooking.SelectedRows[0].Cells["RoomNumber"].Value);

                    DialogResult result = MessageBox.Show("Are you sure you want to cancel this booking?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        DB.Command("DELETE FROM Payment WHERE BookingID = @id", new Dictionary<string, object> { { "@id", bookingId } });
                        DB.Command("DELETE FROM Booking WHERE BookingID = @id", new Dictionary<string, object> { { "@id", bookingId } });
                        DB.Command("UPDATE Room SET Status = 'Available' WHERE RoomId = @roomId", new Dictionary<string, object> { { "@roomId", roomId } });
                        LoadBookings();
                        MessageBox.Show("Booking cancelled successfully.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a booking to cancel.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cancelling the booking:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    for (int i = 0; i < dgvbooking.Columns.Count; i++)
                    {
                        sw.Write(dgvbooking.Columns[i].HeaderText);
                        if (i < dgvbooking.Columns.Count - 1) sw.Write(",");
                    }
                    sw.WriteLine();

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

        private void PrintBookingPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 10);
            Brush brush = Brushes.Black;
            float y = 100;
            float x = 50;

            e.Graphics.DrawString("📋 Hotel Booking List", new Font("Arial", 16, FontStyle.Bold), brush, 250, y - 50);

            for (int i = 0; i < dgvbooking.Columns.Count; i++)
            {
                e.Graphics.DrawString(dgvbooking.Columns[i].HeaderText, font, Brushes.Black, x + (i * 120), y);
            }
            y += 30;

            for (int r = 0; r < dgvbooking.Rows.Count; r++)
            {
                for (int c = 0; c < dgvbooking.Columns.Count; c++)
                {
                    var value = dgvbooking.Rows[r].Cells[c].Value;
                    e.Graphics.DrawString(value?.ToString(), font, brush, x + (c * 120), y);
                }
                y += 25;

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