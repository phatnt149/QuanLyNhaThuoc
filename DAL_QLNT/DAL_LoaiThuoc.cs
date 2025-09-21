using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_QLNT
{
    public class DAL_LoaiThuoc : DBConnect
    {
        public DAL_LoaiThuoc() { }

        public DataTable Get()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LoaiThuoc", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable Get(int id)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LoaiThuoc WHERE maLt = @id", _conn);
            da.SelectCommand.Parameters.AddWithValue("@id", id);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
