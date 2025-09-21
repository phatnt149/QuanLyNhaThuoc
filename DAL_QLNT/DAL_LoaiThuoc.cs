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

        public DataTable Get(string keyword)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LoaiThuoc WHERE tenLt LIKE @tenLt", _conn);
            da.SelectCommand.Parameters.AddWithValue("@tenLt", "%" + keyword + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Insert(string tenLt, string moTa)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO LoaiThuoc (tenLt, moTa) VALUES (@tenLt, @moTa)", _conn);
            cmd.Parameters.AddWithValue("@tenLt", tenLt);
            cmd.Parameters.AddWithValue("@moTa", moTa);

            _conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            _conn.Close();
            return rowsAffected > 0;
        }

        public bool Update(int maLt, string tenLt, string moTa)
        {
            SqlCommand cmd = new SqlCommand("UPDATE LoaiThuoc SET tenLt = @tenLt, moTa = @moTa WHERE maLt = @maLt", _conn);
            cmd.Parameters.AddWithValue("@maLt", maLt);
            cmd.Parameters.AddWithValue("@tenLt", tenLt);
            cmd.Parameters.AddWithValue("@moTa", moTa);
            _conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            _conn.Close();
            return rowsAffected > 0;
        }

        public bool Delete(int maLt)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM LoaiThuoc WHERE maLt = @maLt", _conn);
            cmd.Parameters.AddWithValue("@maLt", maLt);
            _conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            _conn.Close();
            return rowsAffected > 0;
        }
    }
}
