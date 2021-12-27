using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class CongNoDTO
    {
        private string Makhachhang;
        private string Tenkhachhang;
        private string Sodienthoai;
        private string Sotienno;

        public CongNoDTO(string makhachhang, string tenkhachhang, string sodienthoai, string sotienno)
        {
            Makhachhang = makhachhang;
            Tenkhachhang = tenkhachhang;
            Sodienthoai = sodienthoai;
            Sotienno = sotienno;
        }

        public string Makhachhang1 { get => Makhachhang; set => Makhachhang = value; }
        public string Tenkhachhang1 { get => Tenkhachhang; set => Tenkhachhang = value; }
        public string Sodienthoai1 { get => Sodienthoai; set => Sodienthoai = value; }
        public string Sotienno1 { get => Sotienno; set => Sotienno = value; }
    }
}

