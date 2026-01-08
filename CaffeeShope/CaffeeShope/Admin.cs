using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaffeeShope
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure , you want to exit", "comfirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();

            }

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void adimnAdUser1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult check= MessageBox.Show(" Are you sure you want to sign up !"," Comfirmation Message",MessageBoxButtons.YesNo, MessageBoxIcon.Question);    
            if (check == DialogResult.Yes)
            {
                Form1 logout = new Form1();
                logout.Show();
                
                this.Hide();
            }
        }

        private void adminAddProduct1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminDasshbord1.Visible = true;
            adimnAdUser1.Visible=false;
            adminAddProduct1.Visible=false;
            customeradddata1.Visible=false;

            AdminDasshbord adfRome = adminDasshbord1 as AdminDasshbord;
            if (adfRome != null)
            {
                adfRome.refreshdata();
            }
           

        }

        private void adminDasshbord1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminDasshbord1.Visible = false;
            adimnAdUser1.Visible = true;
            adminAddProduct1.Visible = false;
            customeradddata1.Visible=false;

            AdimnAdUser   aduserform = adimnAdUser1 as AdimnAdUser;
            if(aduserform != null)
            {
                aduserform.refreshdata();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminDasshbord1.Visible = false;
            adimnAdUser1.Visible = false;
            adminAddProduct1.Visible = true;
            customeradddata1.Visible = false;

            AdminAddProduct adproform = adminAddProduct1 as AdminAddProduct;
            if (adproform != null)
            {
                adproform.refreshdata();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            adminDasshbord1.Visible = false;
            adimnAdUser1.Visible = false;
            adminAddProduct1.Visible = false;
            customeradddata1.Visible = true;

            Customeradddata adcusform = customeradddata1 as Customeradddata;
            if (adcusform != null)
            {
                adcusform.refreshdata();
            }

        }
    }
    }

