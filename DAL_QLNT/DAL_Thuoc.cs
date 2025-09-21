using System;
using System.Data;
using System.Data.SqlClient;
using DTO_QLNT;

namespace DAL_QLNT
{
    public class DAL_Thuoc : DBConnect
    {
        /// <summary>
        /// Lấy tất cả thuốc
        /// </summary>
        /// <returns></returns>
        public DataTable Get()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Thuoc", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Tìm kiếm thuốc theo tên thuốc
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public DataTable Get(string keyword)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Thuoc WHERE tenThuoc LIKE @tenThuoc", _conn);
            da.SelectCommand.Parameters.AddWithValue("@tenThuoc", "%" + keyword + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetSimple()
        {
            string sql = "SELECT maThuoc, tenThuoc FROM Thuoc";
            SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Thêm thuốc
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool Insert(DTO_Thuoc t)
        {
            string sql = @"INSERT INTO Thuoc (maLt, maNcc, tenThuoc, hamLuong, quyCachDongGoi, hangSx, donViCoBan, soLuong, giaBan, moTa, hinhAnh, hanSd, donViBan, giaTriQuyDoi, giaBanTheoDvBan, soluongtheodvban)
                           VALUES (@maLt, @maNcc, @tenThuoc, @hamLuong, @quyCachDongGoi, @hangSx, @donViCoBan, @soLuong, @giaBan, @moTa, @hinhAnh, @hanSd, @donViBan, @giaTriQuyDoi, @giaBanTheoDvBan, @soLuongTheoDvBan)";
            
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@maLt", t.MaLt);
            cmd.Parameters.AddWithValue("@maNcc", t.MaNcc);
            cmd.Parameters.AddWithValue("@tenThuoc", t.TenThuoc);
            cmd.Parameters.AddWithValue("@hamLuong", t.HamLuong);
            cmd.Parameters.AddWithValue("@quyCachDongGoi", t.QuyCachDongGoi);
            cmd.Parameters.AddWithValue("@hangSx", t.HangSx);
            cmd.Parameters.AddWithValue("@donViCoBan", t.DonViCoBan);
            cmd.Parameters.AddWithValue("@soLuong", t.SoLuong);
            cmd.Parameters.AddWithValue("@giaBan", t.GiaBan);
            cmd.Parameters.AddWithValue("@moTa", t.MoTa);
            cmd.Parameters.AddWithValue("@hanSd", t.HanSd);
            cmd.Parameters.AddWithValue("@donViBan", t.DonViBan);
            cmd.Parameters.AddWithValue("@giaTriQuyDoi", t.GiaTriQuyDoi);
            cmd.Parameters.AddWithValue("@giaBanTheoDvBan", t.GiaBanTheoDvBan);
            cmd.Parameters.AddWithValue("@soLuongTheoDvBan", t.SoLuongTheoDvBan);

            if (t.HinhAnh != null)
                cmd.Parameters.Add("@hinhAnh", SqlDbType.VarBinary).Value = t.HinhAnh;
            else
                cmd.Parameters.Add("@hinhAnh", SqlDbType.VarBinary).Value = DBNull.Value;

            try
            {
                _conn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                _conn.Close();
            }
        }

        /// <summary>
        /// Cập nhật thuốc
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool Update(DTO_Thuoc t)
        {
            string sql = @"UPDATE Thuoc SET maLt=@maLt, maNcc=@maNcc, tenThuoc=@tenThuoc, hamLuong=@hamLuong, quyCachDongGoi=@quyCachDongGoi, hangSx=@hangSx, donViCoBan=@donViCoBan, soLuong=@soLuong, giaBan=@giaBan, moTa=@moTa, hinhAnh=@hinhAnh, hanSd=@hanSd, donViBan=@donViBan, giaTriQuyDoi=@giaTriQuyDoi, giaBanTheoDvBan=@giaBanTheoDvBan, soluongtheodvban=@soLuongTheoDvBan WHERE maThuoc=@maThuoc";

            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@maThuoc", t.MaThuoc);
            cmd.Parameters.AddWithValue("@maLt", t.MaLt);
            cmd.Parameters.AddWithValue("@maNcc", t.MaNcc);
            cmd.Parameters.AddWithValue("@tenThuoc", t.TenThuoc);
            cmd.Parameters.AddWithValue("@hamLuong", t.HamLuong);
            cmd.Parameters.AddWithValue("@quyCachDongGoi", t.QuyCachDongGoi);
            cmd.Parameters.AddWithValue("@hangSx", t.HangSx);
            cmd.Parameters.AddWithValue("@donViCoBan", t.DonViCoBan);
            cmd.Parameters.AddWithValue("@soLuong", t.SoLuong);
            cmd.Parameters.AddWithValue("@giaBan", t.GiaBan);
            cmd.Parameters.AddWithValue("@moTa", t.MoTa);
            cmd.Parameters.AddWithValue("@hanSd", t.HanSd);
            cmd.Parameters.AddWithValue("@donViBan", t.DonViBan);
            cmd.Parameters.AddWithValue("@giaTriQuyDoi", t.GiaTriQuyDoi);
            cmd.Parameters.AddWithValue("@giaBanTheoDvBan", t.GiaBanTheoDvBan);
            cmd.Parameters.AddWithValue("@soLuongTheoDvBan", t.SoLuongTheoDvBan);

            if (t.HinhAnh != null)
                cmd.Parameters.Add("@hinhAnh", SqlDbType.VarBinary).Value = t.HinhAnh;
            else
                cmd.Parameters.Add("@hinhAnh", SqlDbType.VarBinary).Value = DBNull.Value;

            try
            {
                _conn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close();
            }
        }

        /// <summary>
        /// Xóa thuốc theo mã thuốc
        /// </summary>
        /// <param name="maThuoc"></param>
        /// <returns></returns>
        public bool Delete(int maThuoc)
        {
            string sql = "DELETE FROM Thuoc WHERE maThuoc=@maThuoc";

            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@maThuoc", maThuoc);

            try
            {
                _conn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
