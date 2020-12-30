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
    public partial class UC_Storage : UserControl
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
                ("SELECT[PRODUCT].[ProductID]"
                      + " ,[PRODUCT].[ProductName]"
                      + " ,[LOT].[LotID]"
                      + " ,[IMPORT].[SupplierID]"
                      + " ,[IMPORT].[ImportDate]"
                      + " ,[MEDICINE].[Amount]"
                      + " ,[LOT].[ExpirationDate]"
                  + " FROM[PRODUCT],[MEDICINE],[LOT],[IMPORT],[IMPORT_DETAILS]"

                  + " WHERE[PRODUCT].[ProductID] = [MEDICINE].[ProductID]"
                  + " and[PRODUCT].[ProductID] = [LOT].[ProductID]"
                  + " AND[PRODUCT].[ProductID] = [IMPORT_DETAILS].[ProductID]"
                  + " AND[IMPORT_DETAILS].[ImportID] = [IMPORT].[ImportID]"

                  ,con
                );

            db = new SqlCommandBuilder(da);
            dt = new DataTable();
            ds = new DataSet();
            da.Fill(ds, "Customer");
            dt = ds.Tables["Customer"];
            dgv_Thuoc.DataSource = dt;

            con.Close();
        }












        public UC_Storage()
        {
            
            InitializeComponent();
            //uC_Storage_PillDetail1.Hide();
            get_data();
            load_data();
        }

        private void dgv_Thuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                //Get cell information for pill detail
                //this.uC_Storage_PillDetail1.Show();
            }
            //this.uC_Storage_PillDetail1.Show();
        }

        private void btn_NhapHang_Click(object sender, EventArgs e)
        {
            Form form_NhapHang = new FrmImport();
            form_NhapHang.Show();
        }

        private void uC_Storage_PillDetail1_Load(object sender, EventArgs e)
        {

        }

        private void UC_Storage_Load(object sender, EventArgs e)
        {

        }
    }
}
