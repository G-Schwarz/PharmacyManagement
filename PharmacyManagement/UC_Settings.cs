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
    public partial class UC_Settings : UserControl
    {
        public UC_Settings()
        {
            InitializeComponent();
        }

        private void UC_Settings_Load(object sender, EventArgs e)
        {
            pnl_AccountManagement.Visible = true;
            pnl_AddAcc.Visible = false;
        }

        private void btn_AccManagement_Click(object sender, EventArgs e)
        {
            pnl_AccountManagement.Visible = true;
            pnl_AddAcc.Visible = false;
        }

        private void btn_AddAcc_Click(object sender, EventArgs e)
        {
            pnl_AccountManagement.Visible = false;
            pnl_AddAcc.Visible = true;
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            //FrmMain.Close();
        }
    }
}
