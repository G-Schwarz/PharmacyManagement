using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DTO;
using BUS;

namespace PharmacyManagement
{
    public partial class UC_Sale : UserControl
    {










        public UC_Sale()
        {
            InitializeComponent();
        }

        private void uC_Sale_Receipt1_Load(object sender, EventArgs e)
        {

        }

        private void UC_Sale_Load(object sender, EventArgs e)
        {
            btn_BanHang.BackColor = System.Drawing.Color.Orange;
            btn_HoaDon.BackColor = System.Drawing.Color.SteelBlue;
            uC_Sale_Main1.Visible = true;
            uC_Sale_Receipt1.Visible = false;
        }
        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            btn_BanHang.BackColor = System.Drawing.Color.Orange;
            btn_HoaDon.BackColor = System.Drawing.Color.SteelBlue;
            uC_Sale_Main1.Visible = true;
            uC_Sale_Receipt1.Visible = false;
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            btn_BanHang.BackColor = System.Drawing.Color.SteelBlue;
            btn_HoaDon.BackColor = System.Drawing.Color.Orange;
            uC_Sale_Main1.Visible = false;
            uC_Sale_Receipt1.Visible = true;
        }

        private void uC_Sale_Main1_Load(object sender, EventArgs e)
        {

        }
    }
}
