using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CustomerDTO
    {

        private string customerID;
        private string customerType;
        private string customerName;
        private string customerGender;
        private string customerPhone;
        private string customerAddr;
        private string customerDoB;
        private string customerCompany;
        private string customerTIN;
        private string customerEmail;
        private string customerFacebook;
        private string customerDebt;

        public string CustomerID { get => customerID; set => customerID = value; }
        public string CustomerType { get => customerType; set => customerType = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string CustomerGender { get => customerGender; set => customerGender = value; }
        public string CustomerPhone { get => customerPhone; set => customerPhone = value; }
        public string CustomerAddr { get => customerAddr; set => customerAddr = value; }
        public string CustomerDoB { get => customerDoB; set => customerDoB = value; }
        public string CustomerCompany{ get => customerCompany; set => customerCompany = value; }
        public string CustomerTIN { get => customerTIN; set => customerTIN = value; }
        public string CustomerEmail { get => customerEmail; set => customerEmail = value; }
        public string CustomerFacebook { get => customerFacebook; set => customerFacebook = value; }
        public string CustomerDebt { get => customerDebt; set => customerDebt = value; }


        //public KhachHangDTO(string maKH, string hoten,int tuoi,string email,string cmnd,string gioitinh)
        //{
        //    this.maKH = maKH;
        //    this.hoten = hoten;
        //    this.tuoi = tuoi;
        //    this.email = email;
        //    this.cmnd = cmnd;
        //    this.gioitinh = gioitinh;
        //}
    }
}