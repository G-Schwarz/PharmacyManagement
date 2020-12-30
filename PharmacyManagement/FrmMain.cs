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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {   // Color
            Btn_Overview.BackColor = System.Drawing.Color.Orange;
            //Btn_Employee.BackColor = System.Drawing.Color.SteelBlue;
            Btn_Sale.BackColor = System.Drawing.Color.SteelBlue;
            Btn_Storage.BackColor = System.Drawing.Color.SteelBlue;
            Btn_Customers.BackColor = System.Drawing.Color.SteelBlue;
            btn_Index.BackColor = System.Drawing.Color.SteelBlue;
            btn_Setting.BackColor = System.Drawing.Color.SteelBlue;

            // Visible
            uC_overview1.Visible = true;
            
            uC_Sale1.Visible = false;
            uC_Storage1.Visible = false;
            uC_Customers1.Visible = false;
            uC_Index1.Visible = false;
            uC_Settings1.Visible = false;
        }

        private void uC_Customers1_Load(object sender, EventArgs e)
        {

        }



        private void Btn_Overview_Click(object sender, EventArgs e)
        {   // Color
            Btn_Overview.BackColor = System.Drawing.Color.Orange;
            //Btn_Employee.BackColor = System.Drawing.Color.SteelBlue;
            Btn_Sale.BackColor = System.Drawing.Color.SteelBlue;
            Btn_Storage.BackColor = System.Drawing.Color.SteelBlue;
            Btn_Customers.BackColor = System.Drawing.Color.SteelBlue;
            btn_Index.BackColor = System.Drawing.Color.SteelBlue;
            btn_Setting.BackColor = System.Drawing.Color.SteelBlue;

            // Visible
            uC_overview1.Visible = true;
            
            uC_Sale1.Visible = false;
            uC_Storage1.Visible = false;
            uC_Customers1.Visible = false;
            uC_Index1.Visible = false;
            uC_Settings1.Visible = false;
        }

        private void Btn_Employee_Click(object sender, EventArgs e)
        {   // Color
            Btn_Overview.BackColor = System.Drawing.Color.SteelBlue;
            //Btn_Employee.BackColor = System.Drawing.Color.Orange;
            Btn_Sale.BackColor = System.Drawing.Color.SteelBlue;
            Btn_Storage.BackColor = System.Drawing.Color.SteelBlue;
            Btn_Storage.BackColor = System.Drawing.Color.SteelBlue;
            btn_Index.BackColor = System.Drawing.Color.SteelBlue;
            btn_Setting.BackColor = System.Drawing.Color.SteelBlue;

            // Visible
            uC_overview1.Visible = false;
            
            uC_Sale1.Visible = false;
            uC_Storage1.Visible = false;
            uC_Customers1.Visible = false;
            uC_Index1.Visible = false;
            uC_Settings1.Visible = false;
        }

        private void Btn_Sale_Click(object sender, EventArgs e)
        {   // Color
            Btn_Overview.BackColor = System.Drawing.Color.SteelBlue;
            
            Btn_Sale.BackColor = System.Drawing.Color.Orange;
            Btn_Storage.BackColor = System.Drawing.Color.SteelBlue;
            Btn_Customers.BackColor = System.Drawing.Color.SteelBlue;
            btn_Index.BackColor = System.Drawing.Color.SteelBlue;
            btn_Setting.BackColor = System.Drawing.Color.SteelBlue;

            // Visible
            uC_overview1.Visible = false;
            
            uC_Sale1.Visible = true;
            uC_Storage1.Visible = false;
            uC_Customers1.Visible = false;
            uC_Index1.Visible = false;
            uC_Settings1.Visible = false;
        }

        private void Btn_Storage_Click(object sender, EventArgs e)
        {   // Color
            Btn_Overview.BackColor = System.Drawing.Color.SteelBlue;
            //Btn_Employee.BackColor = System.Drawing.Color.SteelBlue;
            Btn_Sale.BackColor = System.Drawing.Color.SteelBlue;
            Btn_Storage.BackColor = System.Drawing.Color.Orange;
            Btn_Customers.BackColor = System.Drawing.Color.SteelBlue;
            btn_Index.BackColor = System.Drawing.Color.SteelBlue;
            btn_Setting.BackColor = System.Drawing.Color.SteelBlue;

            // Visible
            uC_overview1.Visible = false;
            
            uC_Sale1.Visible = false;
            uC_Storage1.Visible = true;
            uC_Customers1.Visible = false;
            uC_Index1.Visible = false;
            uC_Settings1.Visible = false;
        }

        private void Btn_Customers_Click(object sender, EventArgs e)
        {   // Color
            Btn_Overview.BackColor = System.Drawing.Color.SteelBlue;
            //Btn_Employee.BackColor = System.Drawing.Color.SteelBlue;
            Btn_Sale.BackColor = System.Drawing.Color.SteelBlue;
            Btn_Storage.BackColor = System.Drawing.Color.SteelBlue;
            Btn_Customers.BackColor = System.Drawing.Color.Orange;
            btn_Index.BackColor = System.Drawing.Color.SteelBlue;
            btn_Setting.BackColor = System.Drawing.Color.SteelBlue;

            // Visible
            uC_overview1.Visible = false;
            
            uC_Sale1.Visible = false;
            uC_Storage1.Visible = false;
            uC_Customers1.Visible = true;
            uC_Index1.Visible = false;
            uC_Settings1.Visible = false;
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            // Color
            Btn_Overview.BackColor = System.Drawing.Color.SteelBlue;
            //Btn_Employee.BackColor = System.Drawing.Color.SteelBlue;
            Btn_Sale.BackColor = System.Drawing.Color.SteelBlue;
            Btn_Storage.BackColor = System.Drawing.Color.SteelBlue;
            Btn_Customers.BackColor = System.Drawing.Color.SteelBlue;
            btn_Index.BackColor = System.Drawing.Color.SteelBlue;
            btn_Setting.BackColor = System.Drawing.Color.Orange;

            // Visible
            uC_overview1.Visible = false;
            
            uC_Sale1.Visible = false;
            uC_Storage1.Visible = false;
            uC_Customers1.Visible = false;
            uC_Index1.Visible = false;
            uC_Settings1.Visible = true;
        }

        private void btn_Index_Click(object sender, EventArgs e)
        {
            // Color
            Btn_Overview.BackColor = System.Drawing.Color.SteelBlue;
            //Btn_Employee.BackColor = System.Drawing.Color.SteelBlue;
            Btn_Sale.BackColor = System.Drawing.Color.SteelBlue;
            Btn_Storage.BackColor = System.Drawing.Color.SteelBlue;
            Btn_Customers.BackColor = System.Drawing.Color.SteelBlue;
            btn_Index.BackColor = System.Drawing.Color.Orange;
            btn_Setting.BackColor = System.Drawing.Color.SteelBlue;

            // Visible
            uC_overview1.Visible = false;
            
            uC_Sale1.Visible = false;
            uC_Storage1.Visible = false;
            uC_Customers1.Visible = false;
            uC_Index1.Visible = true;
            uC_Settings1.Visible = false;
        }
    }
}
