using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace PharmacyManagement
{
    public partial class UC_Customers : UserControl
    {
        public UC_Customers()
        {
            InitializeComponent();
        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            //Form form = new FrmAddCustomer();
            //form.Show();
            //dataGridView1.Rows.Add("7", "6", "5", "4", "3", "2", "1");

        }

        private void get_data()
        {
            string constring = ConfigurationManager.ConnectionString("db")
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
