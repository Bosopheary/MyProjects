using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CaffeeShope
{
    internal class CustomerData
    {
        SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=CF;Persist Security Info=True;User ID=sa;Password=123;");
        public int CustomerID { get; set; } 
        public string totalprice { get; set; }
        public  string Anoumt { get; set; }
        public string Change {  get; set; }
        public string Date {  get; set; }
        public List<CustomerData> AllCustomerdata()
        {
            List<CustomerData> listcus = new List<CustomerData>();
            string selectData = " select * from Customer";

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
                                CustomerData cuData = new CustomerData();
                                cuData.CustomerID = (int)reader["Cus_id"];
                                cuData.totalprice = reader["totla_price"].ToString();
                                cuData.Anoumt = reader["Amount"].ToString();
                                cuData.Change = reader["Change"].ToString();
                                cuData.Date = reader["Date"].ToString();
                                listcus.Add(cuData);


                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listcus;
        }
    }
   
}
