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

        public void load_data()
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from CUSTOMER";


            da = new SqlDataAdapter
                (
                "(SELECT TOP (2) YEAR(INVOICE.InvoiceDate) as [Year],"
                + "MONTH(INVOICE.InvoiceDate) as [MonthNum],"
                + "DATENAME(MONTH, DATEADD(M, MONTH(INVOICE.InvoiceDate), -1)) Month,"
                + "SUM(INVOICE.Total)[Doanh So],"
                + "COUNT(INVOICE.InvoiceID)[Hoa Don]"
                + "FROM[INVOICE]"
                + "WHERE YEAR(INVOICE.InvoiceDate) = YEAR(GETDATE()) - 1"
                + "GROUP BY  YEAR(INVOICE.InvoiceDate), MONTH(INVOICE.InvoiceDate))"

                + "union"

                + "(SELECT YEAR(INVOICE.InvoiceDate) as [Year],"
                + "MONTH(INVOICE.InvoiceDate) as [MonthNum],"
                + "DATENAME(MONTH, DATEADD(M, MONTH(INVOICE.InvoiceDate), -1)) Month,"

                + "SUM(INVOICE.Total)[Doanh So],"
                + "COUNT(INVOICE.InvoiceID)[Hoa Don]"
                + "FROM[INVOICE]"
                + "WHERE YEAR(INVOICE.InvoiceDate) = YEAR(GETDATE())"
                + "GROUP BY  YEAR(INVOICE.InvoiceDate), MONTH(INVOICE.InvoiceDate))"

                + "order by[Year], [MonthNum]" , con);

            db = new SqlCommandBuilder(da);
            dt = new DataTable();
            ds = new DataSet();
            da.Fill(ds, "Customer");
            dt = ds.Tables["Customer"];
            TB_Overview.DataSource = dt;

            con.Close();



            C_Overview.Series[0].XValueMember = "Month";
            C_Overview.Series[0].YValueMembers = "Doanh So";

            C_Overview2.Series[0].XValueMember = "Month";
            C_Overview2.Series[0].YValueMembers = "Hoa Don";


            C_Overview2.DataSource = dt;

            C_Overview.DataSource = dt;
            

        }










        public void load_data1()
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from CUSTOMER";


            da = new SqlDataAdapter
                ("SELECT TOP(10)[ProductID],"
               + "SUM([Quantity])[Quantity]"
               + "FROM[DB_DRUGSTORE].[dbo].[INVOICE_DETAILS]"
               + "GROUP BY[ProductID]", con);

            db = new SqlCommandBuilder(da);
            dt = new DataTable();
            ds = new DataSet();
            da.Fill(ds, "Customer");
            dt = ds.Tables["Customer"];
            

            con.Close();

            C_OverviewTop.Series[0].XValueMember = "ProductID";
            C_OverviewTop.Series[0].YValueMembers = "Quantity";

            C_OverviewTop.DataSource = dt;


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
                + "HAVING MONTH(INVOICE.InvoiceDate) = (SELECT DATEPART(M, DATEADD(M, 0, GETDATE())))";

            dr = com.ExecuteReader();
            
            while (dr.Read())
            {
                lb_DoanhSoThangTruocView.Text = "Tháng trước: " + dr.GetValue(1).ToString();
                lb_HoaDonThangTruocView.Text = "Tháng trước: " + dr.GetValue(2).ToString();
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
                + "GROUP BY MONTH(INVOICE.InvoiceDate)";
                //+ "HAVING MONTH(INVOICE.InvoiceDate) = (SELECT DATEPART(M, DATEADD(M, 0, GETDATE())))";

            dr = com.ExecuteReader();

            while (dr.Read())
            {
                lb_DoanhSoThangNayView.Text = "Tháng này: " +dr.GetValue(1).ToString();
                lb_HoaDonThangNayView.Text = "Tháng này: " + dr.GetValue(2).ToString();
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
                lb_BaoCaoHoaDonView.Text = "Hóa dơn: " + dr.GetValue(1).ToString();
                lb_BaoCaoDoanhSoView.Text = "Doanh số: " + dr.GetValue(2).ToString();
            }

            con.Close();
        }

        private void lb_DoanhSoThangTruocView_Click(object sender, EventArgs e)
        {

        }

        private void TB_Overview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void C_Overview_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public UC_Overview()
        {
            InitializeComponent();
            get_data();
            load_data();
            load_data1();
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
