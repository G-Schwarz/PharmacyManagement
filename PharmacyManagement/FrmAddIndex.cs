using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement
{
    public partial class FrmAddIndex : Form
    {
        private string MaHang;
        public FrmAddIndex()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu mới?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Save new data to db
                MessageBox.Show("Lưu thành công");
                Clear();
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhập?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Clear();
            }
        }
        private void Clear()
        {
            txt_MaHang.Clear();
            txt_TenHang.Clear();
            txt_DongGoi.Clear();
            txt_LoaiThuoc.Clear();
            txt_GiaBan.Clear();
        }
    }
}
