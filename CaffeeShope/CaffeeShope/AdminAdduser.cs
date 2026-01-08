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
    public partial class AdminAdduser : Form
    {
        public AdminAdduser()
        {
            InitializeComponent();
            DisplayAdduserdata();
        }
        public void DisplayAdduserdata()
        {
            AdminAddUserData userData = new AdminAddUserData();
            List<AdminAddUserData> listdata = new List<AdminAddUserData>();
            dataGridView1.DataSource = listdata;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdminAdduser_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
