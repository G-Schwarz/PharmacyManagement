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
    public partial class FrmAddCustomer : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand com = new SqlCommand();
        SqlCommandBuilder db;

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
                ("select "
                + "[CustomerID]     AS 'ID' ,"
                + "[CustomerType]   AS 'Loại Khách hàng' ,"
                + "[CustomerName]   AS 'Tên Khách hàng' ,"
                + "[Gender]         AS 'Giới tính', "
                + "[Phone]          AS 'SĐT', "
                + "[Addr]           AS 'Địa chỉ', "
                + "[Company]        AS 'Tên công ty', "
                + "[TIN]            AS 'Category ID', "
                + "[Email]          AS 'Email', "
                + "[Facebook]       AS 'Facebook', "
                + "[Debts]          AS 'Nợ' "
                + "from CUSTOMER", con);

            db = new SqlCommandBuilder(da);
            dt = new DataTable();
            ds = new DataSet();
            da.Fill(ds, "Customer");
            dt = ds.Tables["Customer"];
            //dataGridView1.DataSource = dt;
            con.Close();
        }

        void add_data()
        {
            da.Update(dt);
        }

        

        public FrmAddCustomer()
        {
            InitializeComponent();
        }

        private void uC_Add_Customer1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
