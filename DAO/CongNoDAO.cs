using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAO
{
    public class CongNoDAO
    {
        public static DataTable getData()
        {
            SqlConnection conn = DBConnection.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_GetAllKhachHang", conn);
            command.CommandType = CommandType.StoredProcedure;
            conn.Close();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
