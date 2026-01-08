using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;



namespace CaffeeShope
{
    internal class AdminAddUserData
    {
        SqlConnection Connection = new SqlConnection("Data Source=localhost;Initial Catalog=CF;Persist Security Info=True;User ID=sa;Password=123;");
        public int id { get; set; }
        public string Username { get; set; }
        public string Passwords { get; set; } 
        public string image {  get; set; }  
        public string role { get; set; }
        public string status { get; set; }
        public string date_register { get; set; }

        public List<AdminAddUserData> userListData()
        {
            List<AdminAddUserData> listDatas = new List<AdminAddUserData>();
            string selectData = "SELECT * FROM users";

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=CF;Persist Security Info=True;User ID=sa;Password=123;"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(selectData, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                AdminAddUserData userdata = new AdminAddUserData();
                                userdata.id = (int)reader["user_id"];
                                userdata.Username = reader["Username"].ToString();
                                userdata.Passwords = reader["Passwords"].ToString();
                                userdata.image = reader["Profile_image"].ToString();
                                userdata.role = reader["role"].ToString();
                                userdata.status = reader["status"].ToString();
                                userdata.date_register = reader["date_register"].ToString();
                                listDatas.Add(userdata);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listDatas;
        }

    }

}
