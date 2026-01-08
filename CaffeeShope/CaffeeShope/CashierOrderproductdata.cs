using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CaffeeShope
{
    public class CashierOrderproductdata
    {
        SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=CF;Persist Security Info=True;User ID=sa;Password=123;");

        public int ID { get; set; }
        public string productId { get; set; }
        public string productName { get; set; }
        public string Type { get; set; }
        public string Stock { get; set; }
        public float Price { get; set; }
        public string status { get; set; }
        
        public List<CashierOrderproductdata> Availableddata()
        {
            List<CashierOrderproductdata> listData = new List<CashierOrderproductdata>();
            if (ConnectionState.Connecting != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                    string selectData = "SELECT * FROM Product where P_Status =@status";
                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        cmd.Parameters.AddWithValue("@status", "Available");
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CashierOrderproductdata productdata = new CashierOrderproductdata();

                                productdata.ID = reader["id"] != DBNull.Value ? (int)reader["id"] : 0;
                                productdata.productId = reader["P_id"] != DBNull.Value ? reader["P_id"].ToString() : "";
                                productdata.productName = reader["P_Name"] != DBNull.Value ? reader["P_Name"].ToString() : "";
                                productdata.Type = reader["P_Type"] != DBNull.Value ? reader["P_Type"].ToString() : "";
                                productdata.Stock = reader["P_Stock"] != DBNull.Value ? reader["P_Stock"].ToString() : "";


                                productdata.Price = reader["P_Price"] != DBNull.Value
                                                          ? float.Parse(reader["P_Price"].ToString())
                                                          : 0.0f;


                                productdata.status = reader["P_Status"] != DBNull.Value ? reader["P_Status"].ToString() : "";

                                listData.Add(productdata);
                            }
                        }


                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection Failed " + ex);
                }
                finally
                {
                    connection.Close();

                }
                return listData;
            }

        }

    
}
}
