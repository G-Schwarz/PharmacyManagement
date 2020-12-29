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
    public partial class UC_Index : UserControl
    {
        public UC_Index()
        {
            InitializeComponent();
        }
        private int row = -1;
        private void UC_Index_Load(object sender, EventArgs e)
        {

        }

        private void pn_ThongTinThuoc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Form frm = new FrmAddIndex();
            row = -1;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (row == -1)
            {
                MessageBox.Show("Vui lòng chọn mặt hàng để xóa");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa hàng hóa?","",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Xoa hang
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (row == -1)
            {
                MessageBox.Show("Vui lòng chọn mặt hàng để sửa");
                return;
            }
            Form frm = new FrmEditIndex(dgv_DanhMuc.Rows[row].Cells[0].Value.ToString());
            dgv_DanhMuc.Refresh();
            row = -1;
        }

        private void dgv_DanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
        }
    }
}
