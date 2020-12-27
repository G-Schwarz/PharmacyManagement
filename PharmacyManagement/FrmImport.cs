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
            MaximizeBox = false;
            MinimizeBox = false;
            txt_TongTien.Text = "0";
            txt_SoHang.Text = "0";
        }
        private int current_row = -1;
        private void dgv_GioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            current_row = e.RowIndex;
        }

        private void btn_XoaNhapHang_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin đã nhập?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cbb_MaThuoc.ResetText();
                txt_NhaCungCap.ResetText();
                cbb_TenThuoc.ResetText();
                txt_DonGia.Clear();
                txt_SoLo.Clear();
                txt_SoLuong.Clear();
                txt_VAT.Clear();
                txt_GiamGia.Clear();
                dtp_NgayNhap.Value = DateTime.Today;
                dtp_HSD.Value = DateTime.Today;
            }
            current_row = -1;
        }

        private void btn_LuuVaoGio_Click(object sender, EventArgs e)
        {
            if (txt_DonGia.Text == "") { txt_DonGia.Text = "0"; }
            if (txt_SoLuong.Text == "") { txt_SoLuong.Text = "0"; }
            if (txt_VAT.Text == "") { txt_VAT.Text = "0"; }
            if (txt_GiamGia.Text == "") { txt_GiamGia.Text = "0"; }
            string mt, ncc, tt, dg, solo, soluong, vat, nnh, hsd;
            mt = cbb_MaThuoc.Text.ToString();
            ncc = txt_NhaCungCap.Text.ToString();
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
            string[] row = { mt, tt, solo, ncc, soluong, dg, nnh, hsd, vat, txt_GiamGia.Text, thanhtien.ToString() };
            dgv_GioHang.Rows.Add(row);
            cbb_MaThuoc.ResetText();
            txt_NhaCungCap.Clear();
            cbb_TenThuoc.ResetText();
            txt_DonGia.Clear();
            txt_SoLo.Clear();
            txt_SoLuong.Clear();
            txt_VAT.Clear();
            txt_GiamGia.Clear();
            dtp_NgayNhap.Value = DateTime.Today;
            dtp_HSD.Value = DateTime.Today;
            CapNhatSoHang();
        }

        private void btn_XoaPhieuNhap_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn hủy phiếu nhập?","",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgv_GioHang.Rows.Clear();
                dgv_GioHang.Refresh();
                cbb_MaThuoc.ResetText();
                txt_NhaCungCap.Clear();
                cbb_TenThuoc.ResetText();
                txt_DonGia.Clear();
                txt_SoLo.Clear();
                txt_SoLuong.Clear();
                txt_VAT.Clear();
                txt_GiamGia.Clear();
                dtp_NgayNhap.Value = DateTime.Today;
                dtp_HSD.Value = DateTime.Today;
                CapNhatSoHang();
            }
            current_row = -1;
        }

        private void btn_LuuPhieuNhap_Click(object sender, EventArgs e)
        {
            //Luu tung dong vao gio hang
            //VD: for int row = 0; row <= datagridview row; row++ {Push row vao database}
            if (MessageBox.Show("Bạn có muốn tạo phiếu nhập?","",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            current_row = -1;
        }
        private void CapNhatSoHang()
        {
            txt_SoHang.Text = dgv_GioHang.Rows.Count.ToString();
            txt_SoHang.Refresh();
            long tongtien= 0;
            foreach (DataGridViewRow row in dgv_GioHang.Rows)
            {
                tongtien += long.Parse(row.Cells[10].Value.ToString());
            }
            txt_TongTien.Text = tongtien.ToString();
            txt_TongTien.Refresh();
            current_row = -1;
        }

        private void btn_XoaHang_Click(object sender, EventArgs e)
        {
            if (current_row == -1)
            {
                MessageBox.Show("Chọn hàng bạn cần xóa");
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa hàng?","",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dgv_GioHang.Rows.RemoveAt(current_row);
                    CapNhatSoHang();
                }
            }
        }
    }
}
