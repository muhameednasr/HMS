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
    public partial class Booking : Form


    {
        int selectedGuestID = -1;
        int selectedRoomID = -1; // لتخزين الـ RoomID المختار

        private void LoadGuests()
        {

            dgvGuest.DataSource = DB.Select("Guest");


        }

        private void SelectLastAddedGuest()
        {

            DataTable dt = DB.SelectCol("SELECT TOP 1 * FROM Guest ORDER BY GuestID DESC");

            //if (dt.Rows.Count > 0)
            //{
            //    SelectedGuesttxt.Text = dt.Rows[0]["Fname"].ToString() + " " + dt.Rows[0]["Lname"].ToString();
            //    selectedGuestID = Convert.ToInt32(dt.Rows[0]["GuestID"]);
            //}
        }
        private void SearchGuest(string name)
        {
            string query = $"SELECT * FROM Guest WHERE Fname LIKE '%{name}%' OR Lname LIKE '%{name}%'";
            DataTable dt = DB.SelectCol(query);
            dgvGuest.DataSource = dt;
        }


        public Booking()
        {
            InitializeComponent();
        }


        private void AddGuestbtn_Click(object sender, EventArgs e)
        {
            //var guestForm = new Guest();
            //guestForm.FormClosed += (s, args) =>
            //{
            //    LoadGuests();
            //    SelectLastAddedGuest();
            //};
            //guestForm.Show();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            string search = NameGuesttxt.Text.Trim();


            if (string.IsNullOrEmpty(search))
            {
                MessageBox.Show("الرجاء إدخال جزء من اسم العميل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = $@"
        SELECT GuestID, FirstName + ' ' + LastName AS GuestName, Phone, Email
        FROM Guest
        WHERE FirstName LIKE '%{search}%' OR LastName LIKE '%{search}%'
    ";

            DataTable dt = DB.SelectCol(query);

            dgvGuest.DataSource = dt;
        }

        private void dgvGuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // التأكد ان الضغط على صف مش رأس الجدول
            {
                DataGridViewRow row = dgvGuest.Rows[e.RowIndex];

                // تحديث الـ ID والاسم
                selectedGuestID = Convert.ToInt32(row.Cells[0].Value); // أول عمود GuestID
                SelectGuestID.Text = selectedGuestID.ToString();

                SelectedGuesttxt.Text = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString(); // ثاني عمود الاسم الكامل

            }

        }

        private void Booking_Load(object sender, EventArgs e)
        {
            LoadGuests();
            SelectLastAddedGuest();
            LoadRoomTypes(); // تحميل أنواع الغرف في الـ ComboBox
            LoadRoomTypesComboBox();   // تحميل كل الغرف في ComboBox مباشرة
            LoadBookings();
            if (RoomTypecmb.Items.Count > 0)
            {
                RoomTypecmb.SelectedIndex = 0; // اختار أول نوع غرفة تلقائي
                LoadRooms(); // تحميل الغرف من النوع المختار

            }
        }





        /***********************Rooms Tab***************************/


        List<int> selectedRoomIDs = new List<int>(); // تخزن كل الـ RoomID اللي اختارهم العميل

        // لتخزين الـ RoomID لكل غرفة مختارة

        // لتخزين RoomNumber كـ string لعرضها في TextBox
        private List<string> selectedRoomNumbers = new List<string>();

        private void LoadRooms()
        {
            if (RoomTypecmb.SelectedIndex == -1) return;

            string selectedType = RoomTypecmb.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(selectedType)) return;

            string query;

            if (selectedType == "All")
            {
                query = @"
            SELECT r.Room AS RoomID, rt.Name AS RoomType, rt.PricePerNight, r.Status
            FROM Room r
            INNER JOIN RoomType rt ON r.TypeID = rt.TypeID
            WHERE r.Status = 'Available'
        ";
            }
            else
            {
                query = $@"
            SELECT r.Room AS RoomID, rt.Name AS RoomType, rt.PricePerNight, r.Status
            FROM Room r
            INNER JOIN RoomType rt ON r.TypeID = rt.TypeID
            WHERE rt.Name = '{selectedType}' AND r.Status = 'Available'
        ";
            }

            DataTable dt = DB.SelectCol(query);
            dgvRoom.DataSource = dt;
        }


        private void LoadRoomTypes()
        {
            DataTable dt = DB.SelectCol("SELECT TypeID, Name FROM RoomType");
            RoomTypecmb.DataSource = dt;
            RoomTypecmb.DisplayMember = "Name";   // اللي هيظهر للمستخدم
            RoomTypecmb.ValueMember = "TypeID";   // القيمة اللي هنستخدمها في الاستعلام
        }

        private void LoadRoomTypesComboBox()
        {
            DataTable dt = DB.SelectCol("SELECT Name FROM RoomType");

            // إضافة خيار "All" في أول ComboBox
            DataRow newRow = dt.NewRow();
            newRow["Name"] = "All";
            dt.Rows.InsertAt(newRow, 0);

            RoomTypecmb.DataSource = dt;
            RoomTypecmb.DisplayMember = "Name";
            RoomTypecmb.ValueMember = "Name"; // نستخدم الاسم نفسه كقيمة
        }



        private void Room_Num_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void dgvRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRoom.Rows[e.RowIndex];

                int roomID = Convert.ToInt32(row.Cells[0].Value); // رقم الغرفة للحجز
                string roomNumber = row.Cells[0].Value.ToString(); // لعرضه في TextBox

                // لو الغرفة موجودة مسبقًا → شيلها من القوائم
                if (selectedRoomIDs.Contains(roomID))
                {
                    selectedRoomIDs.Remove(roomID);
                    selectedRoomNumbers.Remove(roomNumber);
                }
                else
                {
                    // لو الغرفة مش موجودة مسبقًا → ضيفها للقوائم
                    selectedRoomIDs.Add(roomID);
                    selectedRoomNumbers.Add(roomNumber);
                }

                // عرض كل الغرف المختارة في TextBox
                SelectedRoomtxt.Text = string.Join(", ", selectedRoomNumbers);
            }
        }



        private void CalculateNights()
        {// التأكد من أن Check-out بعد Check-in
            if (dtpChickout.Value.Date <= dtpChickin.Value.Date)
            {
                MessageBox.Show("Please, Select at Least One Room", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNights.Text = "1"; // على الأقل ليلة واحدة
                dtpChickout.Value = dtpChickin.Value.AddDays(1); // تعديل تلقائي لتاريخ الخروج
                return;
            }

            TimeSpan difference = dtpChickout.Value.Date - dtpChickin.Value.Date;
            txtNights.Text = difference.TotalDays.ToString();
        }
        private void Selectbtn_Click(object sender, EventArgs e)
        {
            LoadRooms();
        }

        private void dtpChickin_ValueChanged(object sender, EventArgs e)
        {
            CalculateNights();

        }

        private void dtpChickout_ValueChanged(object sender, EventArgs e)
        {
            CalculateNights();

        }

        private void TotalPricebtn_Click(object sender, EventArgs e)
        {
            if (selectedRoomIDs.Count == 0)
            {
                MessageBox.Show("Please, Select at Least One Room", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int nights = int.Parse(txtNights.Text);
            decimal total = 0;

            foreach (DataGridViewRow row in dgvRoom.Rows)
            {
                int roomID = Convert.ToInt32(row.Cells["RoomID"].Value);

                if (selectedRoomIDs.Contains(roomID))
                {
                    decimal pricePerNight = Convert.ToDecimal(row.Cells["PricePerNight"].Value);
                    total += pricePerNight * nights;
                }
            }

            TotalPricelbl.Text = $"إجمالي السعر: {total:C}"; // C = عملة محلية
        }

        private void ConfirmBookingbtn_Click(object sender, EventArgs e)
        {
            if (selectedGuestID == -1)
            {
                MessageBox.Show("Please Select the Guest first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (selectedRoomIDs.Count == 0)
            {
                MessageBox.Show("Please, Select at Least One Room", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime checkIn = dtpChickin.Value.Date;
            DateTime checkOut = dtpChickout.Value.Date;
            int nights = (checkOut - checkIn).Days;
            if (nights < 1) nights = 1;

            decimal totalPrice = 0;

            foreach (int roomID in selectedRoomIDs)
            {
                decimal pricePerNight = 0;

                // جلب السعر من dgvRoom
                foreach (DataGridViewRow row in dgvRoom.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == roomID)
                    {
                        pricePerNight = Convert.ToDecimal(row.Cells[2].Value);
                        break;
                    }
                }

                totalPrice += pricePerNight * nights;

                // حفظ الحجز
                DB.Command(@"
                    INSERT INTO Booking (GuestID, RoomNumber, CheckinDate, CheckoutDate, TotalPrice)
                    VALUES (@GuestID, @RoomNumber, @CheckIn, @CheckOut, @TotalPrice)
                ", new Dictionary<string, object>
                {
                    {"@GuestID", selectedGuestID },
                    {"@RoomNumber", roomID },
                    {"@CheckIn", checkIn },
                    {"@CheckOut", checkOut },
                    {"@TotalPrice", pricePerNight * nights }
                });

                // تحديث حالة الغرفة لو عندك Status
                DB.Command("UPDATE Room SET [Status] = 'Booked' WHERE Room = @RoomNumber",
                    new Dictionary<string, object> { { "@RoomNumber", roomID } });
            }

            // فورًا عرض الحجوزات في dgvBooking
            LoadBookings();

            // إعادة تعيين القوائم والتكست بوكس
            selectedRoomIDs.Clear();
            selectedRoomNumbers.Clear();
            SelectedRoomtxt.Clear();
            txtNights.Clear();
            TotalPricelbl.Text = "Total Price: 0";

            MessageBox.Show("Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadBookings()
        {
            string query = @"
        SELECT b.BookingID, g.GuestID, g.FirstName + ' ' + g.LastName AS GuestName,
       b.RoomNumber, b.CheckinDate, b.CheckoutDate, b.TotalPrice, r.Status
FROM Booking b
INNER JOIN Guest g ON b.GuestID = g.GuestID
INNER JOIN Room r ON b.RoomNumber = r.Room
ORDER BY b.BookingID DESC

    ";

            DataTable dt = DB.SelectCol(query);
            dgvBooking.DataSource = dt;

            // GuestID عمود مخفي
            if (dgvBooking.Columns["GuestID"] != null)
                dgvBooking.Columns["GuestID"].Visible = false;
        }


        private void dgvBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string query = @"
    SELECT b.BookingID, g.GuestID, g.FirstName + ' ' + g.LastName AS GuestName,
           b.RoomNumber, b.CheckinDate, b.CheckoutDate, b.TotalPrice
    FROM Booking b
    INNER JOIN Guest g ON b.GuestID = g.GuestID
    ORDER BY b.BookingID DESC
";


            dgvBooking.DataSource = DB.SelectCol(query);

        }
        /// ///////////////////////////////////////////////////Edit Booking////////////////////////////////////////

        private void DeleteBookingbtn_Click(object sender, EventArgs e)
        {
            if (dgvBooking.CurrentRow == null)
            {
                MessageBox.Show("الرجاء اختيار حجز للإلغاء.");
                return;
            }

            // جلب بيانات الحجز
            int bookingID = Convert.ToInt32(dgvBooking.CurrentRow.Cells["BookingID"].Value);
            string rooms = dgvBooking.CurrentRow.Cells["RoomNumber"].Value.ToString();
            string[] roomNumbers = rooms.Split(',');

            // تحديث الغرف المرتبطة لتصبح متاحة
            foreach (var room in roomNumbers)
            {
                DB.Command("UPDATE Room SET Status = 'Available' WHERE Room = @RoomNumber",
                    new Dictionary<string, object> { { "@RoomNumber", room } });
            }

            // اختياري: تعملي علم داخلي في الفورم إن الحجز ملغي
            // لو حابة تخفيه من DataGridView فوراً:
            dgvBooking.Rows.Remove(dgvBooking.CurrentRow);

            MessageBox.Show("تم إلغاء الحجز وإرجاع الغرف للعرض.");
            //LoadBookings();  // هيرجع يظهر كل الحجوزات اللي ما اتلغتش (أو هتتحكمي بالفلتر)

        }

        private void EditBookingbtn_Click(object sender, EventArgs e)
        {
            if (dgvBooking.CurrentRow == null)
            {
                MessageBox.Show("الرجاء اختيار حجز للتعديل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // جلب بيانات الحجز من الصف المختار
            int bookingID = Convert.ToInt32(dgvBooking.CurrentRow.Cells["BookingID"].Value);
            selectedGuestID = Convert.ToInt32(dgvBooking.CurrentRow.Cells["GuestID"].Value);
            txtNights.Text = ((DateTime)dgvBooking.CurrentRow.Cells["CheckoutDate"].Value -
                              (DateTime)dgvBooking.CurrentRow.Cells["CheckinDate"].Value).Days.ToString();

            dtpChickin.Value = (DateTime)dgvBooking.CurrentRow.Cells["CheckinDate"].Value;
            dtpChickout.Value = (DateTime)dgvBooking.CurrentRow.Cells["CheckoutDate"].Value;

            // تحميل الغرف المختارة (إذا عندك أكثر من غرفة)
            string roomNumbers = dgvBooking.CurrentRow.Cells["RoomNumber"].Value.ToString();
            selectedRoomNumbers = new List<string>(roomNumbers.Split(','));
            SelectedRoomtxt.Text = roomNumbers;
            selectedRoomIDs = new List<int>();
            foreach (var rn in selectedRoomNumbers)
                selectedRoomIDs.Add(int.Parse(rn));
        }

        private void UpdateBookingbtn_Click(object sender, EventArgs e)
        {
            if (dgvBooking.CurrentRow == null) return;

            int bookingID = Convert.ToInt32(dgvBooking.CurrentRow.Cells["BookingID"].Value);
            DateTime checkIn = dtpChickin.Value.Date;
            DateTime checkOut = dtpChickout.Value.Date;
            int nights = (checkOut - checkIn).Days;
            if (nights < 1) nights = 1;

            decimal totalPrice = 0;
            foreach (int roomID in selectedRoomIDs)
            {
                foreach (DataGridViewRow row in dgvRoom.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == roomID)
                    {
                        decimal pricePerNight = Convert.ToDecimal(row.Cells[2].Value);
                        totalPrice += pricePerNight * nights;
                        break;
                    }
                }
            }

            // تحديث البيانات
            DB.Command(@"
        UPDATE Booking
        SET RoomNumber = @RoomNumber,
            CheckinDate = @CheckIn,
            CheckoutDate = @CheckOut,
            TotalPrice = @TotalPrice
        WHERE BookingID = @BookingID
    ", new Dictionary<string, object>
    {
        {"@RoomNumber", string.Join(",", selectedRoomNumbers)},
        {"@CheckIn", checkIn},
        {"@CheckOut", checkOut},
        {"@TotalPrice", totalPrice},
        {"@BookingID", bookingID}
    });

            LoadBookings(); // تحديث dgvBooking فورًا

            MessageBox.Show("تم حفظ التعديلات بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        /***********************Rooms Tab***************************/



    }
}
