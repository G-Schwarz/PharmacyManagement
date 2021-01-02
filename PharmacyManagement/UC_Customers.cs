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
        //SqlCommand cmd;
        DataTable dt,dt1;
        SqlDataAdapter da,da1;
        DataSet ds,ds1;
        SqlCommand com = new SqlCommand();
        SqlCommandBuilder db,db1;
        SqlDataReader dr1;

        public void get_data()
        {
            con.ConnectionString = @"Data Source=DESKTOP-LQSH5N4;Initial Catalog=DB_DRUGSTORE;Integrated Security=True";
        }

        public void load_data(string a)
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
                //+ "[TIN]            AS 'Category ID', "
                + "[Email]          AS 'Email', "
                + "[Facebook]       AS 'Facebook', "
                + "[Debts]          AS 'Nợ' "
                + "from CUSTOMER" 
                + a, con);

            db = new SqlCommandBuilder(da);
            dt = new DataTable();
            ds = new DataSet();
            da.Fill(ds, "Customer");
            dt = ds.Tables["Customer"];
            dataGridView1.DataSource = dt;

            con.Close();
        }

        void load_combo()
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select CustomerType from CUSTOMER group BY CustomerType";
            dr1 = com.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Type", typeof(string));
            dt.Load(dr1);
            comboBox1.ValueMember = "CustomerType";
            comboBox1.DataSource = dt;
            con.Close();

            
            if (comboBox1.Text == "")
            {
                load_data("");
            }
            else if (comboBox1.Text == "True") 
            {
                load_data("where CustomerType = 1");
            }
            else load_data("where CustomerType = 0");
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load_combo();
        }


        private void cancelbutton_Click(object sender, EventArgs e)
        {
            txb_CustomerID.Text = "";
            txb_CustomerName.Text = "";
            cb_CustomerGroup.Text = "";
            rbtn_Personal.Checked = false;
            rtbn_Company.Checked = false;

            txb_CMND.Text = "";

            rbtn_Male.Checked = false;
            rbtn_Femal.Checked = false;
            txb_PhoneNo.Text = "";
            txb_Email.Text = "";
            txb_CompanyName.Text = "";
            txb_Addresses.Text = "";

            listopen();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            listopen();

            



            SqlCommand com = new SqlCommand("INSERT INTO CUSTOMER " +
                "(CustomerID ,CustomerName  ,Phone ,Addr ,Company ,TIN ,Email ,Facebook ,Debts) " +
                "VALUES (@CustomerID ,@CustomerName  ,@Phone ,@Addr ,@Company ,@TIN ,@Email ,@Facebook ,@Debts)", con);
            //com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CustomerID", txb_CustomerID.Text);
            com.Parameters.AddWithValue("@CustomerType", false);
            com.Parameters.AddWithValue("@CustomerName", txb_CustomerName.Text);
            com.Parameters.AddWithValue("@Gender", false);
            com.Parameters.AddWithValue("@Phone", txb_PhoneNo.Text);
            com.Parameters.AddWithValue("@Addr", txb_Addresses.Text);
            com.Parameters.AddWithValue("@Company", txb_CompanyName.Text);
            com.Parameters.AddWithValue("@TIN", "");
            com.Parameters.AddWithValue("@Email", txb_Email.Text);
            com.Parameters.AddWithValue("@Facebook", "");
            com.Parameters.AddWithValue("@Debts", "");

            con.Open();

                int result = com.ExecuteNonQuery();

            con.Close();
            load_data("");

        }

        void add_data()
        {
            con.Open();
            da.Update(dt);
            con.Close();
        }

        public UC_Customers()
        {
            InitializeComponent();
            panel3.Visible = false;
            panel3.Enabled = false;
            panel6.Visible = false;
            panel6.Enabled = false;
            get_data();
            load_combo();
            
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txb_CompanyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            addopen();
            //dataGridView1.Rows.Add("7", "6", "5", "4", "3", "2", "1");
        }

        private CustomerDTO customerDTO;


        void listopen()
        {
            panel3.Visible = false;
            panel3.Enabled = false;
            panel6.Visible = false;
            panel6.Enabled = false;

            panel1.Visible = true;
            panel1.Enabled = true;
            panel2.Visible = true;
            panel2.Enabled = true;
        }

        void addopen()
        {
            panel3.Visible = true;
            panel3.Enabled = true;
            panel6.Visible = true;
            panel6.Enabled = true;

            panel1.Visible = false;
            panel1.Enabled = false;
            panel2.Visible = false;
            panel2.Enabled = false;
        }

    }

}
