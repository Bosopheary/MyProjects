using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Drawing.Printing;

namespace CaffeeShope
{
    public partial class CashierOrderform : UserControl
    {
        public static int getcusID;
        SqlConnection Connection = new SqlConnection("Data Source=localhost;Initial Catalog=CF;Persist Security Info=True;User ID=sa;Password=123;");

        public CashierOrderform()
        {
            InitializeComponent();
            Displayavailableproduct();
            displaytotalPrice();
            Cashier_menutable.Visible = true;
            Displayorders();
            Cashier_orderstable.Visible = true;
           

        }
        public void refreshdata()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(refreshdata));
                return;
            }
            Displayavailableproduct();
            displaytotalPrice();
            Displayorders();

        }
        public void Displayavailableproduct()
        {
            CashierOrderproductdata allprod =new CashierOrderproductdata();
            List<CashierOrderproductdata> listdata = allprod.Availableddata();
            Cashier_menutable.Visible = false;
            if (listdata.Count>0)
            {
                Cashier_menutable.DataSource = listdata;    
                Cashier_menutable.Visible=true;
            }
           
        }
        public void Displayorders()
        {
            CashierOrderData allorder = new CashierOrderData();
            List<CashierOrderData> listorders = allorder.OrderListDtata();

            Cashier_orderstable.Visible = false;

            if (listorders.Count > 0)
            {
                Cashier_orderstable.DataSource = null; // Clear previous data
                Cashier_orderstable.DataSource = listorders;
                Cashier_orderstable.Visible = true;
            }
        }
        private float totalprice = 0;
        public void displaytotalPrice()
        {
            Idselector();
            try
            {
                if (Connection.State != ConnectionState.Open)
                {
                    Connection.Open();
                }

                string selectdata = "SELECT SUM(P_price) FROM Orders WHERE C_id = @cid";
                using (SqlCommand cmd = new SqlCommand(selectdata, Connection))
                {
                    cmd.Parameters.AddWithValue("@cid", getcusID);
                    object value = cmd.ExecuteScalar();

                  
                    totalprice = (value != DBNull.Value) ? Convert.ToInt32(value) : 0;
                    lbltotalprice.Text = totalprice.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection : " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.Close();
            }
        }



        private void Customersdata_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btadd_Click(object sender, EventArgs e)
        {
            // Select the next customer id
            Idselector();

           
            if (cbtype.SelectedIndex == -1 ||
                cbproductid.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(lblproductname.Text) ||
                nudquantity.Value == 0 ||
                string.IsNullOrWhiteSpace(lblprice.Text))
            {
                MessageBox.Show("Please select the Product first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            string connectionString = "Data Source=localhost;Initial Catalog=CF;Persist Security Info=True;User ID=sa;Password=123;";

           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                   
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    float getprice = 0;

                    string selectOrder = "SELECT * FROM Product WHERE P_id = @pid"; 

                    using (SqlCommand getorder = new SqlCommand(selectOrder, connection))
                    {
                        getorder.Parameters.AddWithValue("@pid", cbproductid.Text.Trim());
                        


                        using (SqlDataReader reader = getorder.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                object rowview = reader["P_Price"];
                                if(rowview !=DBNull.Value)
                                {
                                    getprice = Convert.ToSingle(rowview);
                                }

                            }
                        }
                    }
                    


                        string insertorder = "INSERT INTO Orders (C_id, P_id, P_qut, P_name, P_type, P_price, Orders_date) " +
                                             "VALUES (@cid, @pid, @qut, @pname, @ptype, @price, @date)";

                   
                    using (SqlCommand cmd = new SqlCommand(insertorder, connection))
                    {
                        cmd.Parameters.AddWithValue("@cid", idcen);
                        cmd.Parameters.AddWithValue("@pid", cbproductid.Text.Trim());
                        cmd.Parameters.AddWithValue("@pname", lblproductname.Text.Trim());
                        cmd.Parameters.AddWithValue("@ptype", cbtype.Text.Trim());
                        float totalprice = (getprice) * ((int)nudquantity.Value);
                        cmd.Parameters.AddWithValue("@qut", nudquantity.Value);
                        cmd.Parameters.AddWithValue("@price", totalprice);
                        cmd.Parameters.AddWithValue("@date", DateTime.Today);

                        
                        cmd.ExecuteNonQuery();

                        displaytotalPrice();
                        Displayorders();
                    }

                    MessageBox.Show("Order added successfully.","Infomatiion Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding order: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private int idcen = 0;
        //private int getcusID; //

        public void Idselector()
        {
            try
            {
                string connectionString = "Data Source=localhost;Initial Catalog=CF;Persist Security Info=True;User ID=sa;Password=123;";

                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string selectID = "SELECT TOP 1 Cus_id FROM Customer ORDER BY Cus_id DESC";

                    using (SqlCommand cmd = new SqlCommand(selectID, connect))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            idcen = Convert.ToInt32(result); 
                        }
                        else
                        {
                            idcen = 1; 
                        }
                        getcusID = idcen;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cbtype_SelectedIndexChanged(object sender, EventArgs e)
            
        {
            cbproductid.SelectedIndex = -1;
            cbproductid.Items.Clear();
            lblproductname.Text = " ";
            lblprice.Text = " ";
            

            string selectvalue = cbtype.SelectedItem as string;
           

                    if (!string.IsNullOrEmpty(selectvalue))
                    {
                try
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=CF;Persist Security Info=True;User ID=sa;Password=123;"))

                    {
                        conn.Open();
                        string selectdata = "SELECT * FROM Product WHERE P_Type=@ptype AND P_Status=@status AND date_delete IS NULL ";

                        using (SqlCommand cmd = new SqlCommand(selectdata, conn))
                        {
                            cmd.Parameters.AddWithValue("@ptype", selectvalue);
                            cmd.Parameters.AddWithValue("@status", "Available");


                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())  // 
                                {

                                    string value = reader["P_id"].ToString();
                                    cbproductid.Items.Add(value);
                                }
                            }
                        }
                    }
                }      
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message,
                                            "Error Message",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                            
                        }
                    }
                }

        private void cbproductid_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectvalue= cbproductid.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectvalue))
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=CF;Persist Security Info=True;User ID=sa;Password=123;"))

                    {
                        conn.Open();
                        string selectdata = "SELECT * FROM Product WHERE P_id =@pid AND P_Status=@status AND date_delete IS NULL ";

                        using (SqlCommand cmd = new SqlCommand(selectdata, conn))
                        {
                            cmd.Parameters.AddWithValue("@pid", selectvalue);
                            cmd.Parameters.AddWithValue("@status", "Available");


                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())  // 
                                {
                                    string productname = reader["P_Name"].ToString();
                                    string poductprice = reader["P_Price"].ToString();
                                    lblproductname.Text = productname;
                                    lblprice.Text = poductprice;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message,
                                    "Error Message",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                }
            }
        }

        private void tbamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbamount_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    Idselector();
                    float getamount = Convert.ToSingle(tbamount.Text);
                    float getchange = getamount - totalprice;

                    if (getchange <= -1)
                    {
                        tbamount.Text = " ";
                        lblchange.Text = " ";
                    }
                    else
                    {
                        lblchange.Text = getchange.ToString();
                    }




                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbamount.Text = " ";
                    lblchange.Text = " ";
                }


            }
        }

        private void btpay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbamount.Text) || Cashier_orderstable.RowCount <= 0)
            {
                MessageBox.Show("Something Went Wrong", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure for paying?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string connectionString = "Data Source=localhost;Initial Catalog=CF;Persist Security Info=True;User ID=sa;Password=123;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {   
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                        Idselector();  
                        displaytotalPrice(); 
                        try
                        {
                           
                            string insertdata = "INSERT INTO Customer (Cus_id,totla_price, Amount, Change, Date) " +
                                                "VALUES (@cid, @totaprice, @amount, @Change, @date)";

                            using (SqlCommand cmd = new SqlCommand(insertdata, connection))
                            {
                                displaytotalPrice();
                               
                                cmd.Parameters.AddWithValue("@cid", idcen);
                                cmd.Parameters.AddWithValue("@totaprice", totalprice);
                                cmd.Parameters.AddWithValue("@amount", Convert.ToDecimal(tbamount.Text.Trim()));
                                cmd.Parameters.AddWithValue("@Change", Convert.ToDecimal(lblchange.Text.Trim()));
                                cmd.Parameters.AddWithValue("@date", DateTime.Today);

                               
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Paid Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection Failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
        }
        private int Rowindex = 0; // Track the current row index

        private void byrecipt_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            printDocument1.BeginPrint += new PrintEventHandler(printDocument1_BeginPrint);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Rowindex = 0;

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            displaytotalPrice();
            float y = 0;
            int count = 0;
            int colwidth = 120;
            int headermagin =50;
            int tablMagin = 70;
            Font font = new Font("Arial", 12);
            Font bold = new Font("Arial", 12, FontStyle.Bold);
            Font headerfont = new Font("Arial", 18, FontStyle.Bold);
            Font labelfont = new Font("Arial", 14, FontStyle.Bold);
            float margin = e.PageBounds.Top;
            StringFormat alignCenter = new StringFormat();
            alignCenter.Alignment = StringAlignment.Center;
            alignCenter.LineAlignment = StringAlignment.Center;
            string headerText = "Pheary's CoffeeShop";
            y = (margin + count * headerfont.GetHeight(e.Graphics) + headermagin);
            e.Graphics.DrawString(headerText, headerfont, Brushes.Black, e.MarginBounds.Left +
                (Cashier_orderstable.Columns.Count / 2) * colwidth, y, alignCenter);

            count++;
            y += tablMagin;
            string[] header = { "CID ", " ProductID", "  ProductName ", " Type", " Price", " Quantity " };
            for (int i = 0; i < header.Length; i++)
            {
                y = margin + count * bold.GetHeight(e.Graphics) + tablMagin;
                e.Graphics.DrawString(header[i], bold, Brushes.Black, e.MarginBounds.Left + i * colwidth, y, alignCenter);
            }
            count++;
            float rspace = e.MarginBounds.Bottom - y;
            while (Rowindex < Cashier_orderstable.Rows.Count)
            {
                DataGridViewRow row = Cashier_orderstable.Rows[Rowindex];
                for (int i = 0; i < Cashier_orderstable.Columns.Count; i++)
                {
                    object cellvalue = row.Cells[i].Value;
                    string cell = (cellvalue != null) ? cellvalue.ToString() : String.Empty;
                    y = margin + count * font.GetHeight(e.Graphics) + tablMagin;
                    e.Graphics.DrawString(cell, font, Brushes.Black, e.MarginBounds.Left + i * colwidth, y, alignCenter);
                }
                count++;
                Rowindex++;
                if (y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            int labelmargin = (int)Math.Min(rspace, 200);
            DateTime today = DateTime.Now;
            float labelx = e.MarginBounds.Right - e.Graphics.MeasureString("----------------------------------", labelfont).Width;
            y=e.MarginBounds.Bottom - labelmargin-labelfont.GetHeight(e.Graphics);
           e.Graphics.DrawString("Total Price:" + totalprice + "\n\tAmount: $ " + tbamount.Text + "\n\t--------Change: $" + lblchange.Text, labelfont, Brushes.Black, labelx, y);

            labelmargin = (int)Math.Min(rspace, -40);
            string labelext = today.ToString();
            y = e.MarginBounds.Bottom - labelmargin - labelfont.GetHeight(e.Graphics);
            e.Graphics.DrawString(labelext, labelfont, Brushes.Black, e.MarginBounds.Right - e.Graphics.MeasureString("----------------------------------", labelfont).Width, y);



        }


        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
        public void recmoveandcancel()
        {
            cbtype.SelectedIndex = -1;
            cbproductid.SelectedIndex = -1;
            //lblchange.Text = " ";
            lblprice.Text = " ";
            lblproductname.Text = " ";
            nudquantity.Value = 0;


        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            recmoveandcancel();
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            recmoveandcancel();

        }
    }
}
    

