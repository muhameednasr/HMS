using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

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

            // Event handler for auto-populating price
            rooms_type.SelectedIndexChanged += rooms_type_SelectedIndexChanged;
        }

        private void LoadRoomData()
        {
            string query = @"
                SELECT 
                    R.RoomId AS RoomID,
                    H.Name AS HotelName,
                    R.Status,
                    RT.Name AS RoomTypeName,
                    RT.PricePerNight,
                    R.HotelID,
                    R.TypeID
                FROM Room R
                JOIN RoomType RT ON R.TypeID = RT.TypeID
                JOIN Hotel H ON R.HotelID = H.HotelID";

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
            DataTable dt = DB.Select("Hotel");
            DB.ComboBox(rooms_hotelCombo, dt, "Name", "HotelID");
            rooms_hotelCombo.SelectedIndex = -1;
        }

        private void LoadRoomTypeCombo()
        {
            DataTable dt = DB.Select("RoomType");
            DB.ComboBox(rooms_type, dt, "Name", "TypeID");
            rooms_type.SelectedIndex = -1;
        }

        private void ClearForm()
        {
            rooms_roomID.Clear();
            rooms_hotelCombo.SelectedIndex = -1;
            rooms_roomPrice.Clear();
            rooms_type.SelectedIndex = -1;
            rooms_status.SelectedIndex = -1;
            dgvRooms.ClearSelection();
        }

        private bool ValidateInputs()
        {
            if (!Validator.IsValidInt(rooms_roomID.Text))
            {
                MessageBox.Show("Please enter a valid, numeric Room ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Validator.IsComboBoxSelected(rooms_hotelCombo))
            {
                MessageBox.Show("Please select a hotel.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Validator.IsComboBoxSelected(rooms_type))
            {
                MessageBox.Show("Please select a room type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Validator.IsComboBoxSelected(rooms_status))
            {
                MessageBox.Show("Please select a status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Validator.IsValidDecimal(rooms_roomPrice.Text))
            {
                MessageBox.Show("The room price is invalid. Please select a room type to auto-fill the price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
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
                rooms_hotelCombo.SelectedValue = row.Cells["HotelID"].Value;
                rooms_type.SelectedValue = row.Cells["TypeID"].Value;
                rooms_roomPrice.Text = row.Cells["PricePerNight"].Value.ToString();
                rooms_status.Text = row.Cells["Status"].Value.ToString();
            }
        }

        private void rooms_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rooms_type.SelectedItem is DataRowView drv)
            {
                rooms_roomPrice.Text = drv["PricePerNight"].ToString();
            }
        }

        private void rooms_addBtn_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            DB.Command(
                "INSERT INTO Room (RoomId, HotelID, TypeID, Status) VALUES (@roomId, @hotel, @type, @status)",
                new Dictionary<string, object>
                {
                    {"@roomId", int.Parse(rooms_roomID.Text)},
                    {"@hotel", rooms_hotelCombo.SelectedValue},
                    {"@type", rooms_type.SelectedValue},
                    {"@status", rooms_status.Text}
                });

            MessageBox.Show("Room added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadRoomData();
            ClearForm();
        }

        private void rooms_updateBtn_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            DB.Command(
                "UPDATE Room SET HotelID = @hotel, TypeID = @type, Status = @status WHERE RoomId = @id",
                new Dictionary<string, object>
                {
                    {"@hotel", rooms_hotelCombo.SelectedValue},
                    {"@type", rooms_type.SelectedValue},
                    {"@status", rooms_status.Text},
                    {"@id", int.Parse(rooms_roomID.Text)}
                });

            if (rooms_status.Text.Trim().Equals("Available", StringComparison.OrdinalIgnoreCase))
            {
                DB.Command(
                    "DELETE FROM Booking WHERE RoomNumber = @roomId",
                    new Dictionary<string, object>
                    {
                        {"@roomId", int.Parse(rooms_roomID.Text)}
                    });
            }

            MessageBox.Show("Room updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadRoomData();
            ClearForm();
        }

        private void rooms_deleteBtn_Click_1(object sender, EventArgs e)
        {
            if (!Validator.IsValidInt(rooms_roomID.Text))
            {
                MessageBox.Show("Please select a room to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this room?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DB.Command(
                    "DELETE FROM Room WHERE RoomId = @id",
                    new Dictionary<string, object>
                    {
                        {"@id", int.Parse(rooms_roomID.Text)}
                    });
                MessageBox.Show("Room deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRoomData();
                ClearForm();
            }
        }

        private void rooms_clearBtn_Click_1(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void admin_rooms_Load(object sender, EventArgs e) { }
    }
}