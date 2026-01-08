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

namespace CaffeeShope
{
    public partial class Form1 : Form
    {
        SqlConnection Connection = new SqlConnection("Data Source=localhost;Initial Catalog=CF;Persist Security Info=True;User ID=sa;Password=123;");

        public Form1()
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

        private void btregister_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            form.Hide();

        }

        private void cbshow_CheckedChanged(object sender, EventArgs e)
        {
            tbpassword.PasswordChar = cbshow.Checked ? '\0' : '*';
        }
         public bool emtyfirld()
        {
            if(tbusername.Text ==" " || tbpassword.Text ==" ")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btlogin_Click(object sender, EventArgs e)

        {
            
            if (emtyfirld())
            {
                MessageBox.Show("All Field are required to be filled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // Open the connection
                    Connection.Open();

                    // Define the SQL query
                    string SelectAccount = "SELECT  count(*) FROM users WHERE Username=@usern AND Passwords=@pass AND status=@status";
                    using (SqlCommand cm = new SqlCommand(SelectAccount, Connection))
                    {
                        // Add parameters to the command
                        cm.Parameters.AddWithValue("@usern", tbusername.Text.Trim());
                        cm.Parameters.AddWithValue("@pass", tbpassword.Text.Trim());
                        cm.Parameters.AddWithValue("@status", "Approval"); // Verify if this is the intended status value

                        int roecount=(int)cm.ExecuteScalar();
                        if(roecount > 0)
                        {
                            string selectrole = "Select role FROM users WHERE Username=@usern AND Passwords=@pass ";
                            using (SqlCommand getrole= new SqlCommand(selectrole, Connection))
                            {
                                getrole.Parameters.AddWithValue("@usern", tbusername.Text.Trim());
                                getrole.Parameters.AddWithValue("@pass", tbpassword.Text.Trim());
                                string userrole=getrole.ExecuteScalar()as string;
                                MessageBox.Show("Login Successful !", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tbpassword.Clear();
                                tbusername.Clear();
                                if (userrole == "Admin")
                                {
                                    Admin login = new Admin();
                                    login.Show();
                                    this.Hide();

                                }
                                else if (userrole == "Cashier")
                                {
                                    Cashierform cashier = new Cashierform();
                                    cashier.ShowDialog();
                                    cashier.Hide();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username/Password or there's no admin approval", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                       
                    }
                }
                catch (Exception ex)
                {
                    // Handle any unexpected exceptions here
                    MessageBox.Show("Connection faile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Always ensure the connection is closed
                    Connection.Close();
                }
            }

        }

        private void tbusername_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
