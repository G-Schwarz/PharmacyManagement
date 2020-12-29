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
    public partial class UC_Storage_PillDetail : UserControl
    {
        public UC_Storage_PillDetail()
        {
            InitializeComponent();
        }

        private int flag=0;

        private void UC_Storage_Pilldetail_Visible_Changed(object sender, EventArgs e)
        {
            flag = 0;
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            //Save edit
            MessageBox.Show("Lưu thành công");
            pn_ThongTinThuoc.Enabled = false;
            bt_Huy.Enabled = false;
            bt_Luu.Hide();
            bt_Sua.Show();
            bt_Xoa.Enabled = true;
            flag = 0;
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            flag = 0;
            pn_ThongTinThuoc.Enabled = true;
            bt_Huy.Enabled = true;
            bt_Luu.Show();
            bt_Sua.Hide();
            bt_Xoa.Enabled = false;
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            if (flag != 0)
            {
                if (MessageBox.Show("Bạn có muốn hủy thay đổi?", "", MessageBoxButtons.YesNo) == DialogResult.Yes){
                    //Restore
                }
            }
            pn_ThongTinThuoc.Enabled = false;
            bt_Huy.Enabled = false;
            bt_Luu.Hide();
            bt_Sua.Show();
            bt_Xoa.Enabled = true;
            flag = 0;
        }

        private void bt_TroLai_Click(object sender, EventArgs e)
        {
            if (flag != 0)
            {
                if (MessageBox.Show("Bạn có muốn hủy thay đổi?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //Restore
                }
            }
            pn_ThongTinThuoc.Enabled = false;
            bt_Huy.Enabled = false;
            bt_Luu.Hide();
            bt_Sua.Show();
            bt_Xoa.Enabled = true;
            this.Hide();
        }
        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa thuốc?","",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Delete pill
                this.Hide();
            }
        }

        private void txt_MaThuoc_TextChanged(object sender, EventArgs e)
        {
            flag = 1;
        }

        private void txt_TenThuoc_TextChanged(object sender, EventArgs e)
        {
            flag = 1;
        }

        private void txt_SoLo_TextChanged(object sender, EventArgs e)
        {
            flag = 1;
        }

        private void txt_NhaCungCap_TextChanged(object sender, EventArgs e)
        {
            flag = 1;
        }

        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
            flag = 1;
        }

        private void txt_DonGia_TextChanged(object sender, EventArgs e)
        {
            flag = 1;
        }

        private void dtp_NgayNhap_ValueChanged(object sender, EventArgs e)
        {
            flag = 1;
        }

        private void dtp_HSD_ValueChanged(object sender, EventArgs e)
        {
            flag = 1;
        }

        private void txt_VAT_TextChanged(object sender, EventArgs e)
        {
            flag = 1;
        }

        private void UC_Storage_PillDetail_Load(object sender, EventArgs e)
        {

        }
        public void Set_MaThuoc(string str)
        {
            this.txt_MaThuoc.Text = str;
        }
    }
}
