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
    public partial class FrmImport : Form
    {
        public FrmImport()
        {
            InitializeComponent();
        }

        private void dgv_GioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_XoaNhapHang_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin đã nhập?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cbb_MaThuoc.ResetText();
                cbb_NhaCungCap.ResetText();
                cbb_TenThuoc.ResetText();
                txt_DonGia.Clear();
                txt_SoLo.Clear();
                txt_SoLuong.Clear();
                txt_VAT.Clear();
                txt_GiamGia.Clear();
                dtp_NgayNhap.Value = DateTime.Today;
                dtp_HSD.Value = DateTime.Today;
            }
        }

        private void btn_LuuVaoGio_Click(object sender, EventArgs e)
        {
            if (txt_DonGia.Text == "") { txt_DonGia.Text = "0"; }
            if (txt_SoLuong.Text == "") { txt_SoLuong.Text = "0"; }
            if (txt_VAT.Text == "") { txt_VAT.Text = "0"; }
            if (txt_GiamGia.Text == "") { txt_GiamGia.Text = "0"; }
            string mt, ncc, tt, dg, solo, soluong, vat, nnh, hsd;
            mt = cbb_MaThuoc.Text.ToString();
            ncc = cbb_NhaCungCap.Text.ToString();
            tt = cbb_TenThuoc.Text.ToString();
            dg = txt_DonGia.Text.ToString();
            long long_dongia = long.Parse(txt_DonGia.Text);
            solo = txt_SoLo.Text.ToString();
            soluong = txt_SoLuong.Text.ToString();
            long long_soluong = long.Parse(txt_SoLuong.Text);
            vat = txt_VAT.Text.ToString();
            long long_vat = long.Parse(txt_VAT.Text);
            long long_giamgia = long.Parse(txt_GiamGia.Text);
            nnh = dtp_NgayNhap.Value.Date.ToString("MM/dd/yyyy");
            hsd = dtp_HSD.Value.Date.ToString("MM/dd/yyyy");
            long thanhtien;
            thanhtien = long_dongia * long_soluong + (long_dongia * long_soluong * long_vat / 100) - (long_dongia * long_soluong * long_giamgia / 100); 
            string[] row = { mt, tt, solo, ncc, soluong, dg, nnh, hsd, vat, txt_GiamGia.Text, thanhtien.ToString()};
            dgv_GioHang.Rows.Add(row);
            cbb_MaThuoc.ResetText();
            cbb_NhaCungCap.ResetText();
            cbb_TenThuoc.ResetText();
            txt_DonGia.Clear();
            txt_SoLo.Clear();
            txt_SoLuong.Clear();
            txt_VAT.Clear();
            txt_GiamGia.Clear();
            dtp_NgayNhap.Value = DateTime.Today;
            dtp_HSD.Value = DateTime.Today;
        }

        private void pn_ThongTinThuoc_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
