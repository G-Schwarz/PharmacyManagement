using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace PharmacyManagement
{
    public partial class FrmIndexAdd : Form
    {

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

        void load_combo1()
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select ProductTypeID from PRODUCT_TYPE";
            dr1 = com.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Type", typeof(string));
            dt.Load(dr1);
            cb_IndexAddProductsType.ValueMember = "ProductTypeID";
            cb_IndexAddProductsType.DataSource = dt;
            con.Close();
        }

        void load_combo2()
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT ProductGroupID FROM PRODUCT_GROUP";
            dr1 = com.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Type", typeof(string));
            dt.Load(dr1);
            cb_IndexAddProductsGroup.ValueMember = "ProductGroupID";
            cb_IndexAddProductsGroup.DataSource = dt;
            con.Close();


        }
        void load_combo3()
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT UnitID FROM UNIT";
            dr1 = com.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Type", typeof(string));
            dt.Load(dr1);
            cb_IndexAddPackage.ValueMember = "UnitID";
            cb_IndexAddPackage.DataSource = dt;
            con.Close();


        }


        private void btn_IndexAdd_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_IndexAdd_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("INSERT INTO PRODUCT "
            + "( ProductID, ProductName, ProductTypeID, ProductGroupID, BasePrice, SellingPrice)"
            + "VALUES( @ProductID, @ProductName, @ProductTypeID, @ProductGroupID, @BasePrice, @SellingPrice)", con);
            //com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@ProductID ", txb_IndexAddProductsID.Text);
            com.Parameters.AddWithValue("@ProductName ", txb_IndexAddProductsName.Text);
            com.Parameters.AddWithValue("@ProductTypeID ", cb_IndexAddProductsType.Text);
            com.Parameters.AddWithValue("@ProductGroupID ", cb_IndexAddProductsGroup.Text);
            com.Parameters.AddWithValue("@BasePrice ", Int32.Parse(txb_IndexOriPrice.Text));
            com.Parameters.AddWithValue("@SellingPrice ", Int32.Parse(txb_IndexAddPrice.Text));













            SqlCommand com1 = new SqlCommand("INSERT INTO NON_SERVICES "
                + "(ProductID, ProducerID, Origin, PackagingMethod, UnitID)"
                + "VALUES( @ProductID, @ProducerID, @Origin, @PackagingMethod, @UnitID)", con);
            //com.CommandType = CommandType.StoredProcedure;
            com1.Parameters.AddWithValue("@ProductID ", txb_IndexAddProductsID.Text);
            com1.Parameters.AddWithValue("@ProducerID ", txb_IndexAddProducer.Text);
            com1.Parameters.AddWithValue("@Origin ", txb_IndexAddOrigin.Text);
            com1.Parameters.AddWithValue("@PackagingMethod ", cb_IndexAddPackage.Text);
            com1.Parameters.AddWithValue("@UnitID ", cb_IndexAddPackage.Text);


            con.Open();

            int result = com.ExecuteNonQuery();
            int result1 = com1.ExecuteNonQuery();
            con.Close();
            //load_data();

            this.Close();
        }

        public FrmIndexAdd()
        {
            InitializeComponent();
            get_data();
            load_combo1();
            load_combo2();
            load_combo3();
        }
        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmIndexAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
