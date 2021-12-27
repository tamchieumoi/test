using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAO
{
    public class DBConnection
    {
        public static SqlConnection HamKetNoi()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GCTJS0D\SQLEXPRESS;Initial Catalog=QLBH;Persist Security Info=True;User ID=sa; Password=sa");
            return conn;
        } 
    }
}
