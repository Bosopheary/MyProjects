
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaffeeShope
{
    public partial class Cashierform : Form
    {
        public Cashierform()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
          if(MessageBox.Show("Are you sure , you want to exit ", "Comfirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            DialogResult check= MessageBox.Show("Are you want to Log out","Comfirm Message ",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(check==DialogResult.Yes)
            {
                Form1 logout = new Form1();
                logout.Show();

                this.Hide();

            }
        }

        private void cashierOrderform1_Load(object sender, EventArgs e)
        {

        }

        private void btdasboad_Click(object sender, EventArgs e)
        {
           
        }

        private void btdasboad_Click_1(object sender, EventArgs e)
        {
            adminDasshbord1.Visible = true;
            adminAddProduct2.Visible = false;
            cashierOrderform1.Visible = false;
            customeradddata1.Visible = false;
            AdminDasshbord adfrom= adminDasshbord1 as AdminDasshbord;
            if(adfrom!=null)
            {
                adfrom.refreshdata();
            }
        }

        private void btproduct_Click(object sender, EventArgs e)
        {
            adminDasshbord1.Visible = false;
            adminAddProduct2.Visible = true;
            cashierOrderform1.Visible = false;
            customeradddata1.Visible = false;
            AdminAddProduct adpro = adminAddProduct2 as AdminAddProduct;
            if( adpro!=null)
            {
                adpro.refreshdata();
            }

        }

        private void btoder_Click(object sender, EventArgs e)
        {
            adminDasshbord1.Visible = false;
            adminAddProduct2.Visible = false;
            cashierOrderform1.Visible = true;
            customeradddata1.Visible = false;
            CashierOrderform adorder = cashierOrderform1 as CashierOrderform;
            if (adorder != null)
            {
                adorder.refreshdata();
            }
        }

        private void btcustomer_Click(object sender, EventArgs e)
        {
            adminDasshbord1.Visible = true;
            adminAddProduct2.Visible = false;
            cashierOrderform1.Visible = false;
            customeradddata1.Visible = true;
            Customeradddata adcus = customeradddata1 as Customeradddata;
            if(adcus != null)
            {
                adcus.refreshdata();
            }
        }
    }
}
