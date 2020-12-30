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
    public partial class UC_Overview : UserControl
    {
        //SqlConnection con = new SqlConnection("Data Source=MINIKAZE;Initial Catalog=DB_DRUGSTORE;Integrated Security=True");
        SqlConnection con = new SqlConnection();
        //SqlCommand cmd;
        DataTable dt, dt1;
        SqlDataAdapter da, da1;
        DataSet ds, ds1;
        SqlCommand com = new SqlCommand();
        SqlCommand com1 = new SqlCommand();
        SqlCommandBuilder db, db1;
        SqlDataReader dr,dr1;

        public void get_data()
        {
            con.ConnectionString = @"Data Source=MINIKAZE;Initial Catalog=DB_DRUGSTORE;Integrated Security=True";
        }

        public void load_data_lastmonth()
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT DATENAME(MONTH, DATEADD(M, MONTH(INVOICE.InvoiceDate), -1)) Month,"
                + "SUM(INVOICE.Total)[Doanh So],"
                + "COUNT(INVOICE.InvoiceID)[Hoa Don]"

                + "FROM[INVOICE]"
                + "GROUP BY MONTH(INVOICE.InvoiceDate)"
                + "HAVING MONTH(INVOICE.InvoiceDate) < (SELECT DATEPART(M, DATEADD(M, 0, GETDATE())))";

            dr = com.ExecuteReader();
            
            while (dr.Read())
            {
                lb_DoanhSoThangTruocView.Text = dr.GetValue(1).ToString();
                lb_HoaDonThangTruocView.Text = dr.GetValue(2).ToString();
            }
            
            con.Close();
        }

        public void load_data_thismonth()
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT DATENAME(MONTH, DATEADD(M, MONTH(INVOICE.InvoiceDate), -1)) Month,"
                + "SUM(INVOICE.Total)[Doanh So],"
                + "COUNT(INVOICE.InvoiceID)[Hoa Don]"

                + "FROM[INVOICE]"
                + "GROUP BY MONTH(INVOICE.InvoiceDate)"
                + "HAVING MONTH(INVOICE.InvoiceDate) = (SELECT DATEPART(M, DATEADD(M, 0, GETDATE())))";

            dr = com.ExecuteReader();

            while (dr.Read())
            {
                lb_DoanhSoThangNayView.Text = dr.GetValue(1).ToString();
                lb_HoaDonThangNayView.Text = dr.GetValue(2).ToString();
            }

            con.Close();
        }

        public void load_data_today()
        { 
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT DATENAME(MONTH, DATEADD(M, MONTH(INVOICE.InvoiceDate), -1)) Month,"
                + "SUM(INVOICE.Total)[Doanh So],"
                + "COUNT(INVOICE.InvoiceID)[Hoa Don]"

                + "FROM[INVOICE]"
                + "GROUP BY MONTH(INVOICE.InvoiceDate)"
                + "HAVING MONTH(INVOICE.InvoiceDate) = (SELECT DATEPART(M, DATEADD(M, 0, GETDATE())))";

            dr = com.ExecuteReader();

            while (dr.Read())
            {
                lb_BaoCaoHoaDonView.Text = dr.GetValue(1).ToString();
                lb_BaoCaoDoanhSoView.Text = dr.GetValue(2).ToString();
            }

            con.Close();
        }

















        public UC_Overview()
        {
            InitializeComponent();
            get_data();
            load_data_lastmonth();
            load_data_thismonth();
            load_data_today();
        }

        private void lb_Doanhso_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_BaoCaoDoanhSo_Click(object sender, EventArgs e)
        {

        }

        private void UC_Overview_Load(object sender, EventArgs e)
        {

        }
    }
}
