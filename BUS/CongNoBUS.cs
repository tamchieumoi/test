using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class CongNoBUS
    {
        public static DataTable GetAllKhachHang()
        {
            return CongNoDAO.getData();
        }
    }
}
