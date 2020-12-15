﻿using System;
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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            uC_overview1.Visible = true;
            uC_employee1.Visible = false;
            uC_Sale1.Visible = false;
            uC_Storage1.Visible = false;
            uC_Customers1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Overview_Click(object sender, EventArgs e)
        {
            lb_Status.Text = "Tổng Quan";
            uC_overview1.Visible = true;
            uC_employee1.Visible = false;
            uC_Sale1.Visible = false;
            uC_Storage1.Visible = false;
            uC_Customers1.Visible = false;
        }

        private void Btn_Employee_Click(object sender, EventArgs e)
        {
            lb_Status.Text = "Nhân Sự";
            uC_overview1.Visible = false;
            uC_employee1.Visible = true;
            uC_Sale1.Visible = false;
            uC_Storage1.Visible = false;
            uC_Customers1.Visible = false;
        }

        private void Btn_Sale_Click(object sender, EventArgs e)
        {
            lb_Status.Text = "Bán Hàng";
            uC_overview1.Visible = false;
            uC_employee1.Visible = false;
            uC_Sale1.Visible = true;
            uC_Storage1.Visible = false;
            uC_Customers1.Visible = false;
        }

        private void Btn_Storage_Click(object sender, EventArgs e)
        {
            lb_Status.Text = "Quản Lý Kho";
            uC_overview1.Visible = false;
            uC_employee1.Visible = false;
            uC_Sale1.Visible = false;
            uC_Storage1.Visible = true;
            uC_Customers1.Visible = false;
        }

        private void Btn_Customers_Click(object sender, EventArgs e)
        {
            lb_Status.Text = "Khách Hàng";
            uC_overview1.Visible = false;
            uC_employee1.Visible = false;
            uC_Sale1.Visible = false;
            uC_Storage1.Visible = false;
            uC_Customers1.Visible = true;
        }
    }
}
