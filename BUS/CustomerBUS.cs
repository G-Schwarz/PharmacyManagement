using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class CustomerBUS
    {
        private CustomerDAL khdal;
        public CustomerBUS()
        {
            khdal = new CustomerDAL();
        }
        public bool them(CustomerDTO kh)
        {
            bool kq = khdal.them(kh);
            return kq;
        }
        /*
        public bool xoa(CustomerDTO kh)
        {
            bool kq = khdal.xoa(kh);
            return kq;
        }
        public bool sua(CustomerDTO kh)
        {
            bool kq = khdal.sua(kh);
            return kq;
        }

        */
        public List<CustomerDTO> select()
        {
            return khdal.select();
        }
        public List<CustomerDTO> timkiem(string key)
        {
            return khdal.timkiem(key);
        }
    }
}
