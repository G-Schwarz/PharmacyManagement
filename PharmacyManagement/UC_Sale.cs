﻿using System;
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
    public partial class UC_Sale : UserControl
    {
        public UC_Sale()
        {
            InitializeComponent();
        }

        private void UC_Sale_Load(object sender, EventArgs e)
        {
            uC_Sale_Main1.Visible = true;
            uC_Sale_Receipt1.Visible = false;
        }
        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            uC_Sale_Main1.Visible = true;
            uC_Sale_Receipt1.Visible = false;
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            uC_Sale_Main1.Visible = false;
            uC_Sale_Receipt1.Visible = true;
        }
    }
}
