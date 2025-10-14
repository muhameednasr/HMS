using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    public static class DB
    {
        public static readonly string ConnectionString = "data source=. ; initial catalog= HMS; integrated security = true;TrustServerCertificate =True";
        static SqlCommand cm;


        /*
            DB.Command(
                 "INSERT INTO Patients (Name, Age, Phone) VALUES (@name, @age, @phone)",
                 new Dictionary<string, object>
                         {
                             {"@name", "Mohamed"},
                             {"@age", 24},
                             {"@phone", "01012345678"}
                         }
                     )
        */
        public static void Command(string query, Dictionary<string, object>? parameters = null)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (parameters != null)
                {
                   
                    foreach (var param in parameters)
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                }

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public static DataTable Select(string table)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM {table}", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static void Load(string table, DataGridView dvg)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cm = new SqlCommand($"SELECT * FROM {table}", con);
                con.Open();

                using (SqlDataReader dr = cm.ExecuteReader())
                {
                    dvg.Rows.Clear();

                    while (dr.Read())
                    {
                        object[] row = new object[dr.FieldCount];
                        dr.GetValues(row);
                        dvg.Rows.Add(row);
                    }
                }
            }
        }
        public static DataTable SelectCol(string query)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public static void DGVComboBox(DataGridView dvg,string colName,DataTable dt, string displayMember,string valueMember)
        {

            var col = dvg.Columns[colName] as DataGridViewComboBoxColumn;
            if (col != null)
            {
                col.DataSource = dt;
                col.DisplayMember = displayMember;
                col.ValueMember = valueMember;
            }
        }

        public static void ComboBox(ComboBox comboBox, DataTable dt, string displayMember, string valueMember)
        {
            if (comboBox == null || dt == null) return;

            comboBox.DataSource = dt;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }



    }



}

