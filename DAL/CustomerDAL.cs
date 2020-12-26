using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace DAL
{
    public class CustomerDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public CustomerDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public bool them(CustomerDTO customer)
        {
            string query = string.Empty;
            query += "INSERT INTO [CUSTOMER] ([CustomerID],[CustomerType],[CustomerName],[Gender],[Phone],[Addr],[DoB],[Company],[TIN],[Email],[Facebook],[Debts]) ";
            query += "VALUES (@CustomerID, @CustomerType, @customerName, @customerGender,@customerPhone, @customerAddr, @customerDoB, @customerCompany, @customerTIN, @customerEmail, @customerFacebook, @customerDebt)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@customerID",      customer.CustomerID);
                    cmd.Parameters.AddWithValue("@customerType",    customer.CustomerType);
                    cmd.Parameters.AddWithValue("@customerName",    customer.CustomerName);
                    cmd.Parameters.AddWithValue("@customerGender",  customer.CustomerGender);
                    cmd.Parameters.AddWithValue("@customerPhone",   customer.CustomerPhone);
                    cmd.Parameters.AddWithValue("@customerAddr",    customer.CustomerAddr);
                    cmd.Parameters.AddWithValue("@customerDoB",     customer.CustomerDoB);
                    cmd.Parameters.AddWithValue("@customerCompany", customer.CustomerCompany);
                    cmd.Parameters.AddWithValue("@customerTIN",     customer.CustomerTIN);
                    cmd.Parameters.AddWithValue("@customerEmail",   customer.CustomerEmail);
                    cmd.Parameters.AddWithValue("@customerFacebook",customer.CustomerFacebook);
                    cmd.Parameters.AddWithValue("@customerDebt",    customer.CustomerDebt);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception)
                    {
                        con.Close();
                        MessageBox.Show("Thêm khách hàng thất bại", "thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }

            MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK);
            return true;
        }

        

        public List<CustomerDTO> timkiem(string key)
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [CUSTOMER] ";
            query += "WHERE ([CustomerID] LIKE CONKAT ('%',@key,'%')) ";
            query += "OR ([CustomerType] LIKE CONKAT ('%',@key,'%')) ";
            query += "OR ([CustomerName] LIKE CONKAT ('%',@key,'%')) ";
            query += "OR ([Gender] LIKE CONKAT ('%',@key,'%')) ";
            query += "OR ([Phone] LIKE CONKAT ('%',@key,'%')) ";
            query += "OR ([Addr] LIKE CONKAT ('%',@key,'%')) ";
            query += "OR ([DoB] LIKE CONKAT ('%',@key,'%')) ";
            query += "OR ([Company] LIKE CONKAT ('%',@key,'%')) ";
            query += "OR ([TIN] LIKE CONKAT ('%',@key,'%')) ";
            query += "OR ([Email] LIKE CONKAT ('%',@key,'%')) ";
            query += "OR ([Facebook] LIKE CONKAT ('%',@key,'%')) ";
            query += "OR ([Debts] LIKE CONKAT ('%',@key,'%')) ";
            List<CustomerDTO> lsCustomer = new List<CustomerDTO>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@key", key);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                CustomerDTO customer = new CustomerDTO();
                                customer.CustomerID =       reader["customerID"].ToString();
                                customer.CustomerType =     reader["customerType"].ToString();
                                customer.CustomerName =     reader["customerName"].ToString();
                                customer.CustomerGender =   reader["customerGender"].ToString();
                                customer.CustomerPhone =    reader["customerPhone"].ToString();
                                customer.CustomerAddr =     reader["customerAddr"].ToString();
                                customer.CustomerDoB =      reader["customerDoB"].ToString();
                                customer.CustomerCompany =  reader["customerCompany"].ToString();
                                customer.CustomerTIN =      reader["customerTIN"].ToString();
                                customer.CustomerEmail =    reader["customerEmail"].ToString();
                                customer.CustomerFacebook = reader["customerFacebook"].ToString();
                                customer.CustomerDebt =     reader["customerDebt"].ToString();
                                
                                lsCustomer.Add(customer);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception)
                    {
                        con.Close();
                        //MessageBox.Show("không tìm thấy khách hàng", "thông báo", MessageBoxButtons.OK);
                        return null;
                    }
                }
            }
            //MessageBox.Show("đã tìm thấy khách hàng", "thông báo", MessageBoxButtons.OK);
            return lsCustomer;
        }

        public List<CustomerDTO> select()
        {
            string query = string.Empty;
            query += "SELECT *";
            query += "FROM [CUSTOMER]";

            List<CustomerDTO> lsCustomer = new List<CustomerDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                CustomerDTO customer = new CustomerDTO();
                                customer.CustomerID = reader["customerID"].ToString();
                                customer.CustomerType = reader["customerType"].ToString();
                                customer.CustomerName = reader["customerName"].ToString();
                                customer.CustomerGender = reader["customerGender"].ToString();
                                customer.CustomerPhone = reader["customerPhone"].ToString();
                                customer.CustomerAddr = reader["customerAddr"].ToString();
                                customer.CustomerDoB = reader["customerDoB"].ToString();
                                customer.CustomerCompany = reader["customerCompany"].ToString();
                                customer.CustomerTIN = reader["customerTIN"].ToString();
                                customer.CustomerEmail = reader["customerEmail"].ToString();
                                customer.CustomerFacebook = reader["customerFacebook"].ToString();
                                customer.CustomerDebt = reader["customerDebt"].ToString();
                                lsCustomer.Add(customer);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return lsCustomer;
        }
    }
}