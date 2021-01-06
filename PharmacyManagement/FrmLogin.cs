using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;


namespace PharmacyManagement
{
    public partial class FrmLogin : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public FrmLogin()
        {
            MaximizeBox = false;
            MinimizeBox = false;
            this.Size = new Size(800, 450);
            InitializeComponent();

            con.ConnectionString = @"Data Source=MINIKAZE;Initial Catalog=DB_DRUGSTORE;Integrated Security=True";


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from USERNAME";

            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                if (txtAccount.Text.Equals(dr["Username"].ToString()) && txtPassword.Text.Equals(dr["Pword"].ToString()))
                {
                    //MessageBox.Show("meow");
                    this.Close();
                    Form form = new FrmMain();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập ho8a5c mật khẩu không đúng");
                }

                    
                    //() );
                {

                    
                }
                //else (MessageBox.Show("Liên hệ SĐT: 0793449343"));

                //txtAccount
                //    txtPassword
            }
            con.Close();


            //txtAccount.Text = "1111111111111";


        }

        private void lnklblUnable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Liên hệ SĐT: 0793449343");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //panel1.Location = new Point(0, 0);
            //panel1.Size = new Size(this.Width, this.Height);
            //panel1.Width=this.form 
            this.panel1.Width = this.Width;
            this.panel1.Height = this.Height;
            
            Graphics panel1_graphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(64, 196, 255));
            Rectangle area = new Rectangle(0, 0, this.panel1.Width, this.panel1.Height);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(69, 128, 229), Color.FromArgb(114, 174, 246), 75);
            panel1_graphics.FillRectangle(lgb, area);
            panel1_graphics.DrawRectangle(pen, area);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
