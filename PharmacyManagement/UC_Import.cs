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
    public partial class UC_Import : UserControl
    {
        public UC_Import()
        {
            InitializeComponent();
        }

        private void dgv_GioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form form = new FrmImportDetails();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new FrmImportAdd();
            form.Show();
        }
    }
}
