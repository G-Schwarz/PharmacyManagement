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
    public partial class UC_Customers : UserControl
    {
        //SqlConnection con = new SqlConnection("Data Source=MINIKAZE;Initial Catalog=DB_DRUGSTORE;Integrated Security=True");
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
                //+ "[CustomerType]   AS 'Loại Khách hàng' ,"
                + "[CustomerName]   AS 'Tên Khách hàng' ,"
                + "[Gender]         AS 'Giới tính', "
                + "[Phone]          AS 'SĐT', "
                + "[Addr]           AS 'Địa chỉ', "
                + "[Company]        AS 'Tên công ty', "
                //+ "[TIN]            AS 'Category ID', "
                + "[Email]          AS 'Email', "
                + "[Facebook]       AS 'Facebook', "
                + "[Debts]          AS 'Nợ' "
                + "from CUSTOMER", con);

            db = new SqlCommandBuilder(da);
            dt = new DataTable();
            ds = new DataSet();
            da.Fill(ds, "Customer");
            dt = ds.Tables["Customer"];
            dataGridView1.DataSource = dt;
            con.Close();
        }

        void add_data()
        {
            da.Update(dt);
        }

        public UC_Customers()
        {
            InitializeComponent();
            get_data();
            load_data();
        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            Form form = new FrmAddCustomer();
            form.Show();
            //dataGridView1.Rows.Add("7", "6", "5", "4", "3", "2", "1");
        }

        private CustomerDTO customerDTO;
        public void Load_dataGridView1KhachHang(List<CustomerDTO> lsp)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
        private void btn_CustomerSearch_Click(object sender, EventArgs e)
        {
            add_data();
            MessageBox.Show("meow");
        }
    }
}
