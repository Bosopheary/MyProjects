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

    internal class CashierOrderData
    {
        SqlConnection Connection = new SqlConnection("Data Source=localhost;Initial Catalog=CF;Persist Security Info=True;User ID=sa;Password=123;");

        public int CID { get; set; } //1
        public string ProductID {  get; set; }//2
        public string ProductName { get; set; }//4
        public string Type {  get; set; }//5
        public string  Price { get; set; }//6
        public int Quantity {  get; set; }//3  
        public List<CashierOrderData> OrderListDtata()
        {
            List<CashierOrderData> listData = new List<CashierOrderData>();

            try
            {
               
                if (Connection.State == ConnectionState.Closed)
                {
                    Connection.Open();
                }

                int cuid = 0;

                string SelectCustdaat = "SELECT MAX(Cus_id) FROM Customer";
                using (SqlCommand getcusdata = new SqlCommand(SelectCustdaat, Connection))
                {
                    object result = getcusdata.ExecuteScalar(); 

                    if (result != null && result != DBNull.Value) 
                    {
                        cuid = Convert.ToInt32(result);
                    }
                    else
                    {
                        cuid = 1; 
                    }
                }

                //MessageBox.Show("Fetching orders for C_id: " + cuid); 

               
                string selectdata = "SELECT * FROM Orders WHERE C_id = @cid";
                using (SqlCommand cmd = new SqlCommand(selectdata, Connection))
                {
                    cmd.Parameters.AddWithValue("@cid", cuid);
                    using (SqlDataReader reader = cmd.ExecuteReader()) 
                    {
                        while (reader.Read())
                        {
                            CashierOrderData ordersdata = new CashierOrderData
                            {
                                CID = reader.GetInt32(reader.GetOrdinal("C_id")),
                                ProductID = reader["P_id"].ToString(),
                                ProductName = reader["P_name"].ToString(),
                                Type = reader["P_type"].ToString(),
                                Price = reader["P_price"].ToString(),
                                Quantity = reader.GetInt32(reader.GetOrdinal("P_qut"))
                            };

                            listData.Add(ordersdata);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.Close();
            }

            return listData;
        }


    }
}
