using System.Windows.Forms;

namespace HMS
{
    public partial class Hotel : Form
    {
        public Hotel()
        {
            InitializeComponent();
            //  DB.Command(
            //"INSERT INTO Hotel (Name, Address, Phone,Email,Stars) VALUES (@name, @adress, @phone,@email,@stars)",
            //new Dictionary<string, object>
            //        {
            //               {"@name", "Peramiza"},
            //               {"@adress", "el-Dokki"},
            //               {"@phone", "01012348878"},
            //               {"@email", "peramiza@gmail.com"},
            //               {"@stars", 4}
            //    }
            //    );

            DB.Load("Hotel", dgv);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DB.Command(
          "INSERT INTO Hotel (Name, Address, Phone,Email,Stars) VALUES (@name, @adress, @phone,@email,@stars)",
          new Dictionary<string, object>
                  {
                           {"@name", txtHotel.Text},
                           {"@adress", txtAdress.Text},
                           {"@phone", txtPhone.Text},
                           {"@email", txtEmail.Text},
                           {"@stars", int.Parse(txtStars.Text) }
              }
              );
        }

        private void dvg_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgv.Rows[e.RowIndex];

            var id = row.Cells["HotelId"].Value;       
            var name = row.Cells["Name"].Value;
            var adress = row.Cells["Address"].Value;
            var phone = row.Cells["Phone"].Value;
            var email = row.Cells["Email"].Value;
            var stars = row.Cells["Stars"].Value;

            DB.Command(
                "UPDATE Hotel SET Name=@name,Address=@adress, Phone=@phone, Email=@email,Stars=@stars WHERE HotelId=@id",
                new Dictionary<string, object>
                {
            {"@id", id},
            {"@name", name},
            {"@adress", adress},
            {"@phone", phone},
            {"@email", email},
            {"@stars", stars}
                }
            );
        }
    }
}
