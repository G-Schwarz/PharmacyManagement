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
    public partial class UC_Storage : UserControl
    {
        public UC_Storage()
        {
            InitializeComponent();
            uC_Storage_PillDetail1.Hide();
        }

        private void dgv_Thuoc_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                //Get cell information for pill detail
                this.uC_Storage_PillDetail1.Set_MaThuoc(dgv_Thuoc.Rows[e.RowIndex].Cells[0].Value.ToString());
                //this.uC_Storage_PillDetail1.Show();
            }
            this.uC_Storage_PillDetail1.Show();
        }

        private void btn_NhapHang_Click(object sender, EventArgs e)
        {
            Form form_NhapHang = new FrmImport();
            form_NhapHang.Show();
        }
    }
}
