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
    public partial class Guest : Form
    {
        /*SELECT TOP (1000) [GuestID]
      ,[FirstName]
      ,[LastName]
      ,[DateOfBirth]
      ,[Address]
      ,[Phone]
      ,[Email]
  FROM [HMS].[dbo].[Guest]
*/
        //DB.Command("update table guest set(FirstName,LastName,DateOfBirth,Address,Phone,Email) value(@firstName,@lastName,@dateOfBirth,@adress,@phone,@email) where GuestID=@id ")
        public Guest()
        {
            InitializeComponent();
            DB.Load("Guest", dgv);

            //Dictionary<string, string> dic = new Dictionary<string, string>();
            //dic.Add("ahmed", "2");
            //dic.Add("ramiz", "3");
            //dic.Add("sayed", "4");

            //foreach (var item in dic)
            //{
            //  comboBox1.DataSource = dic[item].ToString();

            //    comboBox1.DisplayMember = item.Key.ToString();
            //    comboBox1.ValueMember = item.Value.ToString();
            //}
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("ahmed", "2");
            dic.Add("ramiz", "3");
            dic.Add("sayed", "4");

            comboBox1.DataSource = new BindingSource(dic, null);
            foreach (var item in dic)
            {
                comboBox1.DisplayMember = item.Key.ToString();
                comboBox1.ValueMember = item.Value.ToString();
            }
        }

        private void dvg_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgv.Rows[e.RowIndex];

            var id = row.Cells["GuestID"].Value;
            var firstName = row.Cells["FirstName"].Value;
            var lastName = row.Cells["LastName"].Value;
            var dateOfBirth = row.Cells["DateOfBirth"].Value;
            var address = row.Cells["Address"].Value;
            var phone = row.Cells["Phone"].Value;
            var email = row.Cells["Email"].Value;
            DB.Command("UPDATE Guest SET FirstName = @firstName,  LastName = @lastName,  DateOfBirth = @dateOfBirth,    Address = @address,   Phone = @phone,    Email = @email WHERE GuestID = @id; ",
                new Dictionary<string, object>
                {
                    {"@id",id },
                    {"@firstName",firstName },
                    {"@lastName",lastName },
                    {"@dateOfBirth",dateOfBirth },
                    {"@address",address },
                    {"@phone", phone},
                    {"@email", email}
                });
        }

        private void Add_Click(object sender, EventArgs e)
        {
            label1.Text =  comboBox1.SelectedValue.ToString();
        }
    }
}
