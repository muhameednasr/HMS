using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMS
{
    public partial class admin_rooms : Form
    {
        public admin_rooms()
        {
            InitializeComponent();
            LoadRoomData();
            LoadRoomTypeCombo();
            LoadHotelCombo();

        }

        private void LoadRoomData()
        {
            string query = @"
      SELECT 
      R.RoomId AS RoomID,
      R.HotelID,
      R.Status,
      R.TypeID,
      RT.Name AS RoomTypeName,
      RT.PricePerNight,
  ISNULL(CONCAT(G.FirstName, ' ', G.LastName), 'Available') AS GuestName
  FROM Room R
  JOIN RoomType RT ON R.TypeID = RT.TypeID
  LEFT JOIN  Booking B ON R.RoomId = B.RoomNumber
  LEFT JOIN Guest G ON B.GuestID = G.GuestID";

            using (SqlConnection con = new SqlConnection(DB.ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRooms.DataSource = dt;
            }
        }




        private void LoadHotelCombo()
        {
            DataTable dt = DB.Select("Hotel"); //  نجيب بيانات الفنادق


            DB.ComboBox(rooms_hotelCombo, dt, "HotelName", "HotelID");

            rooms_hotelCombo.SelectedIndex = -1; // يبدأ فاضي
        }


        //  تحميل نوع الغرفة في ComboBox
        private void LoadRoomTypeCombo()
        {
            DataTable dt = DB.Select("RoomType"); // 🏠 نجيب بيانات أنواع الغرف

            dt.Columns["TypeID"].ColumnName = "ID";

            DB.ComboBox(rooms_type, dt, "Name", "ID");

            rooms_type.SelectedIndex = -1; // يبدأ فاضي
        }


        public bool isEmpty()
        {
            if (rooms_type.SelectedIndex == -1 || string.IsNullOrEmpty(rooms_roomPrice.Text)
                || rooms_status.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }





        private void ClearForm()
        {
            rooms_roomID.Clear();
            rooms_hotelCombo.SelectedIndex = -1;
            rooms_roomPrice.Clear();
            rooms_type.SelectedIndex = -1;
            rooms_status.SelectedIndex = -1;
        }

        private void admin_rooms_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            AdminMain adminMain = new AdminMain();
            adminMain.Show();
            this.Close();
        }

        private void dgvRooms_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dgvRooms.Rows[e.RowIndex].Cells["RoomID"].Value != null)
            {
                DataGridViewRow row = dgvRooms.Rows[e.RowIndex];
                rooms_roomID.Text = row.Cells["RoomID"].Value.ToString();
                rooms_hotelCombo.Text = row.Cells["HotelName"].Value.ToString();
                rooms_roomPrice.Text = row.Cells["Price"].Value.ToString();
                rooms_status.Text = row.Cells["Status"].Value.ToString();

                // لو عايزة ترجعي النوع حسب الاسم
                rooms_type.Text = row.Cells["RoomTypeName"].Value.ToString();

            }
        }



        private void rooms_addBtn_Click_1(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DB.Command
("INSERT INTO Room (RoomId,HotelID, TypeID, Status) VALUES (@roomId,@hotel, @type, @status)",
    new Dictionary<string, object>
    {
        {"@hotel", rooms_hotelCombo.SelectedValue},
        {"@type", rooms_type.SelectedValue},
        {"@status", rooms_status.Text},
        {"@roomId", rooms_roomID.Text},
    }
);


            MessageBox.Show("Room added Successfully");
            LoadRoomData();
            ClearForm();

        }
        private void rooms_updateBtn_Click_1(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //    DB.Command(
            //        "UPDATE Room SET TypeID = @type, Status = @status WHERE Room = @id",
            //        new Dictionary<string, object>
            //        {
            //{"@type", rooms_type.SelectedValue},
            //{"@status", rooms_status.Text},
            //{"@id", int.Parse(rooms_roomID.Text)}
            //        }
            //    );


            DB.Command(
    "UPDATE Room SET TypeID = @type, Status = @status WHERE Room = @id",
    new Dictionary<string, object>
    {
        {"@type", rooms_type.SelectedValue},
        {"@status", rooms_status.Text},
        {"@id", int.Parse(rooms_roomID.Text)}
    }
);


            MessageBox.Show("Room updated Successfully");
            LoadRoomData();
            ClearForm();
        }

        private void rooms_deleteBtn_Click_1(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Please select a room to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = MessageBox.Show("Are you sure you want to delete this room?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                DB.Command
                    (
                        "DELETE FROM Room WHERE Room = @id",
    new Dictionary<string, object>
    {
        {"@id", int.Parse(rooms_roomID.Text)}
    }
                     );
                MessageBox.Show("Room deleted Successfully");
                LoadRoomData();
                ClearForm();
            }

        }
        private void rooms_clearBtn_Click_1(object sender, EventArgs e)
        {

            ClearForm();
        }

        private void dgvRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvRooms.Rows[e.RowIndex].Cells["RoomID"].Value != null)
            {
                DataGridViewRow row = dgvRooms.Rows[e.RowIndex];
                rooms_roomID.Text = row.Cells["RoomID"].Value.ToString();
                rooms_hotelCombo.Text = row.Cells["HotelName"].Value.ToString();
                rooms_roomPrice.Text = row.Cells["Price"].Value.ToString();
                rooms_status.Text = row.Cells["Status"].Value.ToString();

                // لو عايزة ترجعي النوع حسب الاسم
                rooms_type.Text = row.Cells["RoomTypeName"].Value.ToString();

            }
        }

    }
}