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
    public partial class Room : Form
    {
       
        public Room()
        {
            InitializeComponent();



            DataTable dtRoomTypes = DB.SelectCol("SELECT TypeID, Name FROM RoomType");

            DataTable dtHotel = DB.SelectCol("SELECT HotelID, Name FROM Hotel");

            DB.DGVComboBox(dvg, "HotelID", dtHotel, "Name", "HotelID");
            DB.DGVComboBox(dvg, "TypeID", dtRoomTypes, "Name", "TypeID");
            //===================================
            DB.ComboBox(comboBoxHotel, dtHotel, "Name", "HotelID");
            DB.ComboBox(comboBoxType, dtRoomTypes, "Name", "TypeID");

            DB.Load("Room", dvg);



        }


        private void dvg_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = dvg.Rows[e.RowIndex];
            var id = row.Cells["RoomId"].Value;
            var hotel = row.Cells["HotelID"].Value;
            var type = row.Cells["TypeID"].Value;
            var status = row.Cells["Status"].Value;

            MessageBox.Show($"RoomId={id}, Hotel={hotel}, Type={type}, Status={status}");

            DB.Command(
                "UPDATE Room SET HotelID=@hotel,TypeID=@type, Status=@status WHERE RoomId=@id",
                new Dictionary<string, object>
                {
            {"@id", id},
            {"@hotel", hotel},
            {"@type", type},
            {"@status", status},
                }
            );
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            DB.Command(
      "INSERT INTO Room (HotelID, TypeID, Status) VALUES (@hotelID, @typeID, @status)",
      new Dictionary<string, object>
              {
                           {"@hotelID", Convert.ToInt32(comboBoxHotel.SelectedValue)},
                           {"@typeID", Convert.ToInt32(comboBoxType.SelectedValue)},
                           {"@status", txtStatus.Text}                 
          }
          );
            DB.Load("Room", dvg);

        }
    }
}
