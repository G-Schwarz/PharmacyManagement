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
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            MaximizeBox = false;
            MinimizeBox = false;
            this.Size = new Size(800, 450);
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form = new FrmMain();
            form.Show();
        }

        private void lnklblUnable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Liên hệ SĐT: 0793449343");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
