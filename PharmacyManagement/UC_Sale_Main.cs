using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PharmacyManagement
{
    public partial class UC_Sale_Main : UserControl
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
                ("SELECT TOP(5)[PRODUCT].[ProductID] AS [Mã Thuốc]"
                + ",[PRODUCT].[ProductName] AS [Tên Thuốc]"
                + ",[MEDICINE].[Amount] AS [Tồn Kho] "
                + ",[PRODUCT].[SellingPrice] AS [Giá Bán]"
                + "FROM[PRODUCT],[MEDICINE]"
                + "WHERE[PRODUCT].[ProductID] = [MEDICINE].[ProductID]", con);

            db = new SqlCommandBuilder(da);
            dt = new DataTable();
            ds = new DataSet();
            da.Fill(ds, "Customer");
            dt = ds.Tables["Customer"];
            TB_Search.DataSource = dt;

            con.Close();
        }


        void load_comboEmployee()
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT [EmployeeName] FROM [EMPLOYEE]";
            dr1 = com.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Type", typeof(string));
            dt.Load(dr1);
            cb_NhanVien.ValueMember = "EmployeeName";
            cb_NhanVien.DataSource = dt;
            con.Close();
        }

        void load_comboCustomer()
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT [CustomerName] FROM [CUSTOMER] GROUP BY [CustomerName]";
            dr1 = com.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Type", typeof(string));
            dt.Load(dr1);
            cb_Khach.ValueMember = "CustomerName";
            cb_Khach.DataSource = dt;
            con.Close();
        }












        public UC_Sale_Main()
        {
            InitializeComponent();
            get_data();
            load_data();
            load_comboEmployee();
            load_comboCustomer();
            SearchTB.Visible = false;
        }
        private void UC_Sale_Main_Load(object sender, EventArgs e)
        {

        }

        private void Dgv_ProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txb_SearchProduct_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("[Mã Thuốc] LIKE '%{0}%' OR [Tên Thuốc] LIKE '%{0}%'", txb_SearchProduct.Text);
            TB_Search.DataSource = dv;
        }

        private void SearchTB_Leave(object sender, EventArgs e)
        {
            SearchTB.Visible = false;
        }

        private void pnl_ThanhToan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_Khach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_NhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchTB_Enter(object sender, EventArgs e)
        {
            SearchTB.Visible = true;
        }

        private void txb_SearchProduct_Leave(object sender, EventArgs e)
        {
            SearchTB.Visible = false;
        }

        private void txb_SearchProduct_Enter(object sender, EventArgs e)
        {
            SearchTB.Visible = true;
        }

        private void SearchTB_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
