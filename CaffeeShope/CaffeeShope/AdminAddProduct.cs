using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CaffeeShope
{
    public partial class AdminAddProduct : UserControl
    {
        SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=CF;Persist Security Info=True;User ID=sa;Password=123;");
        public AdminAddProduct()
        {
            InitializeComponent();
            displayData();
            dataGridView1.Visible = true;
        }
        public void refreshdata()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(refreshdata));
                return;
            }
            displayData();

        }
        public bool emtyfield()
        {
            return string.IsNullOrWhiteSpace(tbproductID.Text) ||
                   string.IsNullOrWhiteSpace(tbproductname.Text) ||
                   string.IsNullOrWhiteSpace(tbprice.Text) ||
                   string.IsNullOrWhiteSpace(tbStock.Text) ||
                   string.IsNullOrWhiteSpace(cbstatus.Text) ||
                   string.IsNullOrWhiteSpace(cbtype.Text)||
                    pibimage.Image == null;
            
        }
        public  void displayData()
        {
            AdminAddProductData prodata = new AdminAddProductData();
            List<AdminAddProductData> listdata = prodata.ProductListData();
            dataGridView1.Visible=false;
            if (listdata.Count > 0)
            {
                dataGridView1.DataSource = listdata;
                dataGridView1.Visible = true; // Show DataGridView only if data exists
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btadd_Click(object sender, EventArgs e)
        {
            if (emtyfield()) 
            {
                MessageBox.Show("All fields are required to be filled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    string selectproid = "SELECT * FROM Product WHERE P_id = @proid";
                    using (SqlCommand selectid = new SqlCommand(selectproid, connection))
                    {
                        selectid.Parameters.AddWithValue("@proid", tbproductID.Text.Trim());
                        SqlDataAdapter da = new SqlDataAdapter(selectid);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Product ID: " + tbproductID.Text.Trim() + " is already taken.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            string directory = @"C:\Users\ASUS\source\repos\CaffeeShope\CaffeeShope\Product_Directory";
                            if (!Directory.Exists(directory))
                            {
                                Directory.CreateDirectory(directory);
                            }

                            string path = Path.Combine(directory, tbproductID.Text.Trim() + ".jpg");

                            if (!string.IsNullOrEmpty(pibimage.ImageLocation))
                            {
                                File.Copy(pibimage.ImageLocation, path, true);
                            }
                            else
                            {
                                MessageBox.Show("No image selected!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            string insertproduct = "INSERT INTO Product(P_id, P_Name, P_Type, P_Stock, P_Price, P_Status, P_image, P_date) " +
                                                   "VALUES(@proid, @proname, @protype, @prostock, @proprice, @prostatus, @proimage, @prodate)";

                            using (SqlCommand cmd = new SqlCommand(insertproduct, connection))
                            {
                                cmd.Parameters.AddWithValue("@proid", tbproductID.Text.Trim());
                                cmd.Parameters.AddWithValue("@proname", tbproductname.Text.Trim());
                                cmd.Parameters.AddWithValue("@protype", cbtype.Text.Trim());
                                cmd.Parameters.AddWithValue("@prostock", int.Parse(tbStock.Text));
                                cmd.Parameters.AddWithValue("@proprice", decimal.Parse(tbprice.Text)); 
                                cmd.Parameters.AddWithValue("@prostatus", cbstatus.Text.Trim());
                                cmd.Parameters.AddWithValue("@proimage", path);
                                cmd.Parameters.AddWithValue("@prodate", DateTime.Today);

                                cmd.ExecuteNonQuery();
                                ClearFile();
                                MessageBox.Show("Product added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                displayData();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
              
                    OpenFileDialog openimage= new OpenFileDialog();
                    openimage.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";
                    if (openimage.ShowDialog() == DialogResult.OK)
                    {
                        string imagePath = openimage.FileName;
                        pibimage.ImageLocation = imagePath;
                    }

                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        public  void ClearFile()
        {
            tbproductID.Clear();
            tbproductname.Clear();
            tbStock.Clear();
            tbprice.Clear();
            cbstatus.SelectedIndex = -1;
            cbtype.SelectedIndex = -1;

            
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            ClearFile();
        }
        private int id = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells[0].Value);
                tbproductID.Text = row.Cells[1].Value.ToString();
                tbproductname.Text = row.Cells[2].Value.ToString();
                cbtype.Text = row.Cells[3].Value.ToString();
                tbStock.Text = row.Cells[4].Value.ToString();
                tbprice.Text = row.Cells[5].Value.ToString();
                cbstatus.Text = row.Cells[6].Value.ToString();
                //pibimage.Text = row.Cells[7].Value.ToString();

                string imagepath = row.Cells[7].Value?.ToString();
                try
                {
                    if (!string.IsNullOrEmpty(imagepath) && File.Exists(imagepath))
                    {
                        pibimage.Image = Image.FromFile(imagepath);
                    }
                    else
                    {
                        pibimage.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No image !" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }





        }

        private void btupdates_Click(object sender, EventArgs e)

        {
            if (emtyfield())
            {
                MessageBox.Show("All Filed are requied to be filled", "Error Messgae ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult result = MessageBox.Show("Are you to update ProductID" + tbproductID.Text.Trim() + "?","Comfirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if(ConnectionState.Connecting!= ConnectionState.Open)
                        {
                            connection.Open();
                        }
                        string updateQuery = "UPDATE Product SET P_Name=@pname, P_Type=@ptype, P_Stock=@stock, P_Price=@price, P_Status=@status, date_update=@update WHERE id=@id";
                        using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                        {
                            // cmd.Parameters.AddWithValue("@pid", tbproductID.Text.Trim()); // not needed if you update by id only

                            cmd.Parameters.AddWithValue("@pname", tbproductname.Text.Trim());
                            cmd.Parameters.AddWithValue("@ptype", cbtype.Text.Trim());
                            cmd.Parameters.AddWithValue("@stock", tbStock.Text.Trim());
                            cmd.Parameters.AddWithValue("@price", tbprice.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", cbstatus.Text.Trim());
                            cmd.Parameters.AddWithValue("@update", DateTime.Today);
                            cmd.Parameters.AddWithValue("@id", id); // Ensure id is set correctly
                            int rowaffact= cmd.ExecuteNonQuery();
                            if (rowaffact > 0)
                            {
                                MessageBox.Show("Update is SuccessFuly!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayData();

                            }
                            else
                            {
                                MessageBox.Show("No record updated. Please check the user ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                        }
                        
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Connection Failed:" + ex ,"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if(ConnectionState.Connecting != ConnectionState.Open)
                        {
                            connection.Close(); 
                        }

                    }
                }
            }
           
        }

        private void btdelet_Click(object sender, EventArgs e)
        {
            if(id<=0)
            {
                MessageBox.Show("Please select a product to delete", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result= MessageBox.Show("Are you to Delete this Product","Comfirmation Message",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if(ConnectionState.Connecting!= ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    string deletproduct = "Delete From Product where id=@id";
                    using(SqlCommand cmd = new SqlCommand(deletproduct,connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int rowaffect= cmd.ExecuteNonQuery();
                        ClearFile();
                        if (rowaffect <= 0)
                        {
                            MessageBox.Show("Delete is Successfuly!","Information Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
                            displayData();
                        }
                        else
                        {
                            MessageBox.Show("No recode Delete please Check Product ID","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }

                    }
                } 
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Failed:" + ex, "Error Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if(ConnectionState.Connecting != ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
