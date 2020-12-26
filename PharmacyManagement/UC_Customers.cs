using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlClient;
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

        public UC_Customers()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=MINIKAZE;Initial Catalog=DB_DRUGSTORE;Integrated Security=True";
        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from CUSTOMER";

            //SqlDataReader dr = com.ExecuteReader();


            SqlDataAdapter da = new SqlDataAdapter("select * from CUSTOMER", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;



            con.Close();


            /*












            //dataGridView1.Columns.Add(new DataColumn("colStatus", typeof(string)));

            listView1.Columns.Add("meow", 1);
            listView1.View = View.Details;



            con.Open();
            cmd = new SqlCommand("select * from CUSTOMER", con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "test");
            con.Close();

            //dt = ds.Tables["test"];
            int i;
            for (i = 0; i <= (dt.Rows.Count); i++ )
            {
                //dataGridView1.
                listView1.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                //listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());

            }

            */

        }














        private CustomerDTO customerDTO;
        public void Load_dataGridView1KhachHang(List<CustomerDTO> lsp)
            {
            customerDTO = new CustomerDTO();


                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lsp;
                //dataGridView1.Enabled = false;
                //this.BindingContext[dataGridView1.DataSource];
                //myCurrencyManager.Refresh();
        }

            /*/private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            //FormChonPhong formcp = new FormChonPhong();
            //formcp.Show();
                CustomerBUS customerbus = new CustomerBUS();
                List<CustomerDTO> lsp = customerbus.select();
                this.Load_dataGridView1KhachHang(lsp);
                //txtPhong.Text = FormChonPhong.ValueChonPhong; //Need fix. Không hiện giá trị ngay lập tức mà phải nhấn vào lable DS Phòng để hiện giá trị của Phòng đã chọn
            }*/
     

        /*private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            //Form form = new FrmAddCustomer();
            //form.Show();
            //dataGridView1.Rows.Add("7", "6", "5", "4", "3", "2", "1");

        }*/

        private void get_data()
        {
            //string constring = ConfigurationManager.ConnectionString("db");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
