using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CaffeeShope
{
    public partial class AdminDasshbord : UserControl
    {
        SqlConnection Conn = new SqlConnection("Data Source=localhost;Initial Catalog=CF;Persist Security Info=True;User ID=sa;Password=123;");

        public AdminDasshbord()
        {
            InitializeComponent();
            displayTotalCashier();
            displayTotalCustomer();
            displayTodaylIncom();
            displaytotalPrice();
        }
        public void refreshdata()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(refreshdata));
                return;
            }
            displayTotalCashier();
            displayTotalCustomer();
            displayTodaylIncom();
            displaytotalPrice();
        }
        public void displayTotalCashier()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=CF;Persist Security Info=True;User ID=sa;Password=123;"))
            {
                if (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();
                        string selectdata = "Select Count(*) from users where role =@role AND status=@status ";
                        using(SqlCommand cmd = new SqlCommand(selectdata, connection))
                        {
                            cmd.Parameters.AddWithValue("@role", "Cashier");
                            cmd.Parameters.AddWithValue("@status", "Approval");
                          SqlDataReader reader = cmd.ExecuteReader();
                            if(reader.Read())
                            {
                                int count = Convert.ToInt32(reader[0]);
                                lblcashierCount.Text = count.ToString();

                            }
                            reader.Close(); 
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Failed!" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
            }   }
        }

        public void displayTotalCustomer()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=CF;Persist Security Info=True;User ID=sa;Password=123;"))
            {
                if(connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();
                        string selectcustomer = "select count(id) from Customer";
                        using (SqlCommand cmd = new SqlCommand(selectcustomer, connection))
                        {
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                int count = Convert.ToInt32(reader[0]);
                                lblTotalCustomer .Text = count.ToString();

                            }
                            reader.Close();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Coonection Failed!"+ex,"Errro Message ",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
        public void displaytotalPrice()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=CF;Persist Security Info=True;User ID=sa;Password=123;"))
            {
                if (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();
                        string selectcustomer = "select sum(totla_price) from Customer";
                        using (SqlCommand cmd = new SqlCommand(selectcustomer, connection))
                        {
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                int count = Convert.ToInt32(reader[0]);
                                lblTotalincom.Text = "$"+count.ToString("0.00");

                            }
                            reader.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Coonection Failed!" + ex, "Errro Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
        public void displayTodaylIncom()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=CF;Persist Security Info=True;User ID=sa;Password=123;"))
            {
                if (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();
                        string selectcustomer = "SELECT COALESCE(SUM(totla_price), 0) FROM Customer WHERE CONVERT(date, Date)= @date";

                        using (SqlCommand cmd = new SqlCommand(selectcustomer, connection))
                        {
                            cmd.Parameters.AddWithValue("@date", DateTime.Today);

                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                int count = Convert.ToInt32(reader[0]);
                                lblTodaylincom.Text = "$" + count.ToString("0.00");
                            }
                            reader.Close();

                          }  
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Failed!" + ex, "Errro Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void AdminDasshbord_Load(object sender, EventArgs e)
        {

        }
    }
}
