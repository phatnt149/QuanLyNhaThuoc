using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLNT;
using static System.Net.Mime.MediaTypeNames;


namespace DAL_QLNT
{
    public class DAL_NhapHang : DBConnect
    {
        public DAL_NhapHang() { }

        public DataTable Get()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NhapHang", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Insert(DTO_NhapHang nh)
        {
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO NhapHang (maThuoc, donViNhap, giaTriQuyDoi, soLuongNhap, giaNhap, moTa, ngayNhap, thanhTien, userName) " +
                "VALUES (@maThuoc, @donViNhap, @giaTriQuyDoi, @soLuongNhap, @giaNhap, @moTa, @ngayNhap, @thanhTien, @userName)", _conn);

            cmd.Parameters.AddWithValue("@maThuoc", nh.MaThuoc);
            cmd.Parameters.AddWithValue("@donViNhap", nh.DonViNhap);
            cmd.Parameters.AddWithValue("@giaTriQuyDoi", nh.GiaTriQuyDoi);
            cmd.Parameters.AddWithValue("@soLuongNhap", nh.SoLuongNhap);
            cmd.Parameters.AddWithValue("@giaNhap", nh.GiaNhap);
            cmd.Parameters.AddWithValue("@moTa", nh.MoTa ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@ngayNhap", nh.NgayNhap);
            cmd.Parameters.AddWithValue("@thanhTien", nh.ThanhTien);
            cmd.Parameters.AddWithValue("@userName", nh.UserName);

            // Lấy bảng thuốc ra và cập nhật số lượng thuốc mới
            SqlCommand getThuocCmd = new SqlCommand("SELECT soLuong FROM Thuoc WHERE maThuoc = @maThuoc", _conn);
            getThuocCmd.Parameters.AddWithValue("@maThuoc", nh.MaThuoc);

            _conn.Open();
            // Lấy số lượng thuốc hiện tại
            object soLuongObj = getThuocCmd.ExecuteScalar();
            int soLuongHienTai = 0;
            if (soLuongObj != null && soLuongObj != DBNull.Value)
            {
                soLuongHienTai = Convert.ToInt32(soLuongObj);
            }
            // Cập nhật số lượng thuốc mới
            int soLuongMoi = soLuongHienTai + nh.SoLuongNhap;
            SqlCommand updateThuocCmd = new SqlCommand("UPDATE Thuoc SET soLuong = @soLuongMoi WHERE maThuoc = @maThuoc", _conn);
            updateThuocCmd.Parameters.AddWithValue("@soLuongMoi", soLuongMoi);
            updateThuocCmd.Parameters.AddWithValue("@maThuoc", nh.MaThuoc);
            updateThuocCmd.ExecuteNonQuery();

            int rowsAffected = cmd.ExecuteNonQuery();
            _conn.Close();
            return rowsAffected > 0;
        }

        public bool Update(DTO_NhapHang nh)
        {
            SqlCommand cmd = new SqlCommand(
                "UPDATE NhapHang SET maThuoc = @maThuoc, donViNhap = @donViNhap, giaTriQuyDoi = @giaTriQuyDoi, " +
                "soLuongNhap = @soLuongNhap, giaNhap = @giaNhap, moTa = @moTa, ngayNhap = @ngayNhap, " +
                "thanhTien = @thanhTien, userName = @userName WHERE maNhapHang = @maNhapHang", _conn);
            cmd.Parameters.AddWithValue("@maNhapHang", nh.MaNhapHang);
            cmd.Parameters.AddWithValue("@maThuoc", nh.MaThuoc);
            cmd.Parameters.AddWithValue("@donViNhap", nh.DonViNhap);
            cmd.Parameters.AddWithValue("@giaTriQuyDoi", nh.GiaTriQuyDoi);
            cmd.Parameters.AddWithValue("@soLuongNhap", nh.SoLuongNhap);
            cmd.Parameters.AddWithValue("@giaNhap", nh.GiaNhap);
            cmd.Parameters.AddWithValue("@moTa", nh.MoTa ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@ngayNhap", nh.NgayNhap);
            cmd.Parameters.AddWithValue("@thanhTien", nh.ThanhTien);
            cmd.Parameters.AddWithValue("@userName", nh.UserName);

            // Lấy bảng thuốc ra và cập nhật số lượng thuốc mới
            SqlCommand getThuocCmd = new SqlCommand("SELECT soLuong FROM Thuoc WHERE maThuoc = @maThuoc", _conn);
            SqlCommand oldNhapHangCmd = new SqlCommand("SELECT soLuongNhap FROM NhapHang WHERE maNhapHang = @maNhapHang", _conn);
            getThuocCmd.Parameters.AddWithValue("@maThuoc", nh.MaThuoc);
            oldNhapHangCmd.Parameters.AddWithValue("@maNhapHang", nh.MaNhapHang);

            _conn.Open();
            // Lấy số lượng thuốc hiện tại
            object soLuongOld = oldNhapHangCmd.ExecuteScalar();
            object soLuongObj = getThuocCmd.ExecuteScalar();
            int soLuongHienTai = 0;
            if (soLuongObj != null && soLuongOld != null && soLuongObj != DBNull.Value && soLuongOld != DBNull.Value)
            {
                soLuongHienTai = Convert.ToInt32(soLuongObj) - Convert.ToInt32(soLuongOld);
            }
            // Cập nhật số lượng thuốc mới
            int soLuongMoi = soLuongHienTai + nh.SoLuongNhap;
            SqlCommand updateThuocCmd = new SqlCommand("UPDATE Thuoc SET soLuong = @soLuongMoi WHERE maThuoc = @maThuoc", _conn);
            updateThuocCmd.Parameters.AddWithValue("@soLuongMoi", soLuongMoi);
            updateThuocCmd.Parameters.AddWithValue("@maThuoc", nh.MaThuoc);
            updateThuocCmd.ExecuteNonQuery();

            int rowsAffected = cmd.ExecuteNonQuery();
            _conn.Close();
            return rowsAffected > 0;
        }

        public bool Delete(int maNhapHang, int maThuoc)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM NhapHang WHERE maNhapHang = @maNhapHang", _conn);
            cmd.Parameters.AddWithValue("@maNhapHang", maNhapHang);

            // xoá số lượng thuốc
            // Lấy bảng thuốc ra
            SqlCommand getThuocCmd = new SqlCommand("SELECT soLuong FROM Thuoc WHERE maThuoc = @maThuoc", _conn);
            SqlCommand oldNhapHangCmd = new SqlCommand("SELECT soLuongNhap FROM NhapHang WHERE maNhapHang = @maNhapHang", _conn);
            getThuocCmd.Parameters.AddWithValue("@maThuoc", maThuoc);
            oldNhapHangCmd.Parameters.AddWithValue("@maNhapHang", maNhapHang);

            _conn.Open();
            // Lấy số lượng thuốc hiện tại
            object soLuongOld = oldNhapHangCmd.ExecuteScalar();
            object soLuongObj = getThuocCmd.ExecuteScalar();
            int soLuongMoi = 0;
            if (soLuongObj != null && soLuongOld != null && soLuongObj != DBNull.Value && soLuongOld != DBNull.Value)
            {
                soLuongMoi = Convert.ToInt32(soLuongObj) - Convert.ToInt32(soLuongOld);
            }
            SqlCommand updateThuocCmd = new SqlCommand("UPDATE Thuoc SET soLuong = @soLuongMoi WHERE maThuoc = @maThuoc", _conn);
            updateThuocCmd.Parameters.AddWithValue("@soLuongMoi", soLuongMoi);
            updateThuocCmd.Parameters.AddWithValue("@maThuoc", maThuoc);
            updateThuocCmd.ExecuteNonQuery();

            int rowsAffected = cmd.ExecuteNonQuery();
            _conn.Close();
            return rowsAffected > 0;
        }
    }
}
