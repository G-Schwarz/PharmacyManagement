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
    public partial class FrmEditIndex : Form
    {
        private string MaHang;
        public FrmEditIndex(string str = "")
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            MaHang = str;
            txt_MaHang.Text = MaHang;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            pn_ThongTinThuoc.Enabled = true;
            btn_Huy.Enabled = true;
            btn_Luu.Enabled = true;
            btn_Sua.Enabled = false;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu thay đổi?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Save new data to db
                MessageBox.Show("Lưu thành công");
                pn_ThongTinThuoc.Enabled = false;
                btn_Huy.Enabled = false;
                btn_Luu.Enabled = false;
                btn_Sua.Enabled = true;
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy thay đổi?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Re-get data from database
                pn_ThongTinThuoc.Enabled = false;
                btn_Huy.Enabled = false;
                btn_Luu.Enabled = false;
                btn_Sua.Enabled = true;
            }
        }
    }
}
