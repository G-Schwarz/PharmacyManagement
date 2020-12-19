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
    public partial class UC_Sale_Receipt : UserControl
    {
        public UC_Sale_Receipt()
        {
            InitializeComponent();
        }

        private void dgv_ReceiptList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form form = new FrmReceiptDetails();
            form.Show();
        }
    }
}
