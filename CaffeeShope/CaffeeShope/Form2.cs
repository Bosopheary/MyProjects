using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CaffeeShope
{
    public partial class Form2 : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=CF;Persist Security Info=True;User ID=sa;Password=123;");
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure , you want to exit", "comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void btsignin_Click(object sender, EventArgs e)
        {
            
        }

        private void btsignin_Click_1(object sender, EventArgs e)
        {

            Form1 loging = new Form1();
            loging.Show();

            this.Hide();
        }
        public bool emthyFirld()
        {
            if (tbusername.Text == " " || tbpasssword.Text == " " || tbcomfirm.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void cbshow_CheckedChanged(object sender, EventArgs e)
        {
            tbpasssword.PasswordChar = cbshow.Checked ? '\0' : '*';
            tbcomfirm.PasswordChar= cbshow.Checked ? '\0' : '*';

        }

        private void btsingup_Click(object sender, EventArgs e)

        {
      
            if (emthyFirld())
            {
                MessageBox.Show("All Fields are requied to be  filled ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                 if (connection.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connection.Open();
                            String SelectUsername = "SELECT * FROM users WHERE Username=@usern";

                            using (SqlCommand checkusername = new SqlCommand(SelectUsername, connection))
                            {
                                checkusername.Parameters.AddWithValue("@usern", tbusername.Text.Trim());

                                SqlDataAdapter da = new SqlDataAdapter(checkusername);
                                DataTable dt = new DataTable();
                                da.Fill(dt);

                                if (dt.Rows.Count >= 1)
                                {
                                    String usern = char.ToUpper(tbusername.Text[0]) + tbusername.Text.Substring(1);
                                    MessageBox.Show(usern + " is already taken.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else if (tbpasssword.Text != tbcomfirm.Text)
                                {
                                    MessageBox.Show("Password does not match.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else if (tbpasssword.Text.Length < 4)
                                {
                                    MessageBox.Show("Invalid password. At least 4 characters needed.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    String InsertData = "INSERT INTO users(Username, Passwords, Profile_image, role, status, date_register) " +
                                                        "VALUES(@usern, @pass, @profile, @role, @status, @date)";

                                    DateTime today = DateTime.Today;

                                    using (SqlCommand cn = new SqlCommand(InsertData, connection))
                                    {
                                        cn.Parameters.AddWithValue("@usern", tbusername.Text.Trim());
                                        cn.Parameters.AddWithValue("@pass", tbpasssword.Text.Trim());
                                        cn.Parameters.AddWithValue("@profile", " ");
                                        cn.Parameters.AddWithValue("@role", "Cashier");
                                        cn.Parameters.AddWithValue("@status", "Approval");
                                        cn.Parameters.AddWithValue("@date", today);

                                        cn.ExecuteNonQuery();
                                        MessageBox.Show("Registered successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            Form2 form = new Form2();
                                            form.ShowDialog();

                                            this.Hide();



                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                



            }
        }
            

           
        
    }
}
