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
using System.IO;

namespace CaffeeShope
{
    public partial class AdimnAdUser : UserControl
    {
        SqlConnection Connection = new SqlConnection("Data Source=localhost;Initial Catalog=CF;Persist Security Info=True;User ID=sa;Password=123;");

        public AdimnAdUser()
        {
            InitializeComponent();
            DisplayAdduserdata();
            dataGridView1.Visible = true;
        }
        public void refreshdata()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(refreshdata));
                return;
            }
            DisplayAdduserdata();

        }

        public void DisplayAdduserdata()
        {
            AdminAddUserData userData = new AdminAddUserData();
            List<AdminAddUserData> listdata = userData.userListData();
            dataGridView1.Visible = false;

            // Check if data is available
            if (listdata.Count > 0)
            {
                dataGridView1.DataSource = listdata;
                dataGridView1.Visible = true; // Show DataGridView only if data exists
            }
        }
        private int id = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked cell is not a header or invalid
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // Fill in the textboxes and comboboxes
            id = Convert.ToInt32(row.Cells[0].Value);
            tbusername.Text = row.Cells[1].Value?.ToString() ?? "";
            tbpassword.Text = row.Cells[2].Value?.ToString() ?? "";
            cbrole.Text = row.Cells[4].Value?.ToString() ?? "";
            cbstatus.Text = row.Cells[5].Value?.ToString() ?? "";

            // Load image from file if available (assumed to be in column 3)
            string imagepath = row.Cells[3].Value?.ToString();
            try
            {
                if (!string.IsNullOrEmpty(imagepath) && File.Exists(imagepath))
                {
                    pbimage.Image = Image.FromFile(imagepath);
                }
                else
                {
                    pbimage.Image = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No image !"+ex,"Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }
        public bool EmptyField()
        {
            return string.IsNullOrWhiteSpace(tbusername.Text) ||
                   string.IsNullOrWhiteSpace(tbpassword.Text) ||
                   string.IsNullOrWhiteSpace(cbrole.Text) ||
                   string.IsNullOrWhiteSpace(cbstatus.Text) ||
                   pbimage.Image == null;
        }

        private void btadd_Click(object sender, EventArgs e)
        {

            if (EmptyField())
            {
                MessageBox.Show("All fields are required to be filled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                if (Connection.State != ConnectionState.Open)
                {
                    Connection.Open();
                }


                string selectUser = "SELECT * FROM users WHERE Username = @user";
                using (SqlCommand cmd = new SqlCommand(selectUser, Connection))
                {
                    cmd.Parameters.AddWithValue("@user", tbusername.Text.Trim());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count >= 1)
                    {
                        string usern = char.ToUpper(tbusername.Text[0]) + tbusername.Text.Substring(1);
                        MessageBox.Show(usern + " is already taken.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }



                string directory = @"C:\Users\ASUS\source\repos\CaffeeShope\CaffeeShope\User_Directory\";
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                string path = Path.Combine(directory, tbusername.Text.Trim() + ".jpg");


                File.Copy(pbimage.ImageLocation, path, true);


                string insertData = "INSERT INTO users(Username, Passwords, Profile_image, role, status, date_register) " +
                                    "VALUES(@usern, @pass, @profile, @role, @status, @date)";
                using (SqlCommand cn = new SqlCommand(insertData, Connection))
                {
                    cn.Parameters.AddWithValue("@usern", tbusername.Text.Trim());
                    cn.Parameters.AddWithValue("@pass", tbpassword.Text.Trim());
                    cn.Parameters.AddWithValue("@profile", path);
                    cn.Parameters.AddWithValue("@role", cbrole.Text.Trim());
                    cn.Parameters.AddWithValue("@status", cbstatus.Text.Trim());
                    cn.Parameters.AddWithValue("@date", DateTime.Today);

                    cn.ExecuteNonQuery();
                    clearfield();
                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    DisplayAdduserdata();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFile.FileName;
                    pbimage.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            if (EmptyField())
            {
                MessageBox.Show("All fields are required to be filled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to update Username: " + tbusername.Text.Trim() + "?",
                                                        "Confirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (Connection.State != ConnectionState.Open)
                        {
                            Connection.Open();
                        }
                       

                        string updateData = "UPDATE users SET Username = @users, Passwords = @pass, role = @role, status = @status WHERE user_id = @id";
                        using (SqlCommand cmd = new SqlCommand(updateData, Connection))
                        {
                            cmd.Parameters.AddWithValue("@users", tbusername.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", tbpassword.Text.Trim());
                            cmd.Parameters.AddWithValue("@role", cbrole.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", cbstatus.Text.Trim());
                            cmd.Parameters.AddWithValue("@id", id); 

                            int rowsAffected = cmd.ExecuteNonQuery();
                            clearfield();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Update successful!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DisplayAdduserdata();
                            }
                            else
                            {
                                MessageBox.Show("No record updated. Please check the user ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (Connection.State == ConnectionState.Open)
                            Connection.Close();
                    }
                }
            }
        }
         
        public  void clearfield()
        {
            tbusername.Clear();
            tbpassword.Clear();
            cbrole.SelectedIndex = -1;
            cbstatus.SelectedIndex = -1;
            pbimage.Image = null;
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            clearfield();
        }

        private void btdelet_Click(object sender, EventArgs e)
        {
            // Only check for a valid ID rather than all fields
            if (id <= 0)
            {
                MessageBox.Show("Please select a user to delete.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete Username: " + tbusername.Text.Trim() + "?",
                                                    "Confirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (Connection.State != ConnectionState.Open)
                    {
                        Connection.Open();
                    }

                    string deletedata = "DELETE FROM users WHERE user_id = @id";
                    using (SqlCommand cmd = new SqlCommand(deletedata, Connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        clearfield();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Delete successful!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DisplayAdduserdata();
                        }
                        else
                        {
                            MessageBox.Show("No record deleted. Please check the user ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (Connection.State == ConnectionState.Open)
                        Connection.Close();
                }
            }
        }
    }
}
