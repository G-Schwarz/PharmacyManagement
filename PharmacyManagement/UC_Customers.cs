using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Form form = new FrmAddCustomer();
            form.Show();
        }
    }
}
