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


namespace CaffeeShope
{
    public partial class Customeradddata : UserControl
    {
        SqlConnection Connectiom = new SqlConnection("Data Source=localhost;Initial Catalog=CF;Persist Security Info=True;User ID=sa;Password=123;");
        public Customeradddata()
        {
            InitializeComponent();
            DisplayCusdata();
            Customer_dataTable.Visible = true;

        }
        public void refreshdata()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(refreshdata));
                return;
            }

            DisplayCusdata();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void DisplayCusdata()
        {
            CustomerData allcus = new CustomerData();
            List<CustomerData> listcus = allcus.AllCustomerdata();

            if (listcus.Count > 0)
            {
                Customer_dataTable.Visible = true;  // Show only if data exists
                Customer_dataTable.DataSource = null; // Reset before assigning new data
                Customer_dataTable.DataSource = listcus;
            }


        }

        private void Customer_dataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
