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
    public partial class UC_Sale_Receipt : UserControl
    {

        //SqlConnection con = new SqlConnection("Data Source=MINIKAZE;Initial Catalog=DB_DRUGSTORE;Integrated Security=True");
        SqlConnection con = new SqlConnection();
        //SqlCommand cmd;
        DataTable dt, dt1;
        SqlDataAdapter da, da1;
        DataSet ds, ds1;
        SqlCommand com = new SqlCommand();
        SqlCommandBuilder db, db1;
        SqlDataReader dr1;

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

                /****** Script for SelectTopNRows command from SSMS  ******/
                ("SELECT[INVOICE].[InvoiceID] as [Mã Đơn]"
                + ",[INVOICE].[CustomerID] as [Khách Hàng]"
                + ",[INVOICE].[EmployeeID] as [Nhân viên giao dịch]"

                + ",[INVOICE].[InvoiceDate] as [Thời gian bán]"
                + ",[INVOICE].[MethodID] as [Quy cách giao dịch]"

                + ",[INVOICE].[VAT] as [VAT]"
                + ",[INVOICE].[Discount] as [Giảm Giá]"
                + ",[INVOICE].[Total] as [Tổng Tiền]"
                + "FROM[INVOICE]"



                  , con
                );

            db = new SqlCommandBuilder(da);
            dt = new DataTable();
            ds = new DataSet();
            da.Fill(ds, "Customer");
            dt = ds.Tables["Customer"];
            dgv_ReceiptList.DataSource = dt;

            con.Close();
        }







        public UC_Sale_Receipt()
        {
            InitializeComponent();
            get_data();
            load_data();
        }

        private void dgv_ReceiptList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form form = new FrmReceiptDetails();
            form.Show();
        }

        private void UC_Sale_Receipt_Load(object sender, EventArgs e)
        {

        }
    }
}
