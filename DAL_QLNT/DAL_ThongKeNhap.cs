using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Security.Cryptography;
using DTO_QLNT;
using System.Collections;
using System.Windows.Forms;
namespace DAL_QLNT
{
    public class DAL_ThongKeNhap : DBConnect
    {
        public DataTable GetChiTietNhapHangTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            string sql = @"
        SELECT nh.maNhapHang, t.tenThuoc, nh.donViNhap, nh.giaTriQuyDoi,
               nh.soLuongNhap, nh.giaNhap, nh.moTa, nh.ngayNhap,
               (nh.soLuongNhap * nh.giaNhap) AS ThanhTien,
               nh.userName, t.hamLuong, t.hangSx
        FROM NhapHang nh
        INNER JOIN Thuoc t ON nh.maThuoc = t.maThuoc
        WHERE CAST(nh.ngayNhap AS DATE) BETWEEN @tuNgay AND @denNgay
        ORDER BY nh.ngayNhap";

            SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
            da.SelectCommand.Parameters.AddWithValue("@tuNgay", tuNgay.Date);
            da.SelectCommand.Parameters.AddWithValue("@denNgay", denNgay.Date);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        // Lấy chi tiết nhập hàng theo tháng
        public DataTable GetChiTietNhapHangTheoThang(int thang, int nam)
        {
            string sql = @"
                SELECT 
                    nh.maNhapHang,
                    t.tenThuoc,
                    nh.donViNhap,
                    nh.giaTriQuyDoi,
                    nh.soLuongNhap,
                    nh.giaNhap,
                    nh.moTa,
                    nh.ngayNhap,
                    (nh.soLuongNhap * nh.giaNhap) AS ThanhTien,
                    nh.userName,
                    t.hamLuong,
                    t.hangSx
                FROM NhapHang nh
                INNER JOIN Thuoc t ON nh.maThuoc = t.maThuoc
                WHERE MONTH(nh.ngayNhap) = @Thang AND YEAR(nh.ngayNhap) = @Nam
                ORDER BY nh.ngayNhap";

            SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
            da.SelectCommand.Parameters.AddWithValue("@Thang", thang);
            da.SelectCommand.Parameters.AddWithValue("@Nam", nam);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Lấy chi tiết nhập hàng theo năm
        public DataTable GetChiTietNhapHangTheoNam(int nam)
        {
            string sql = @"
                SELECT 
                    nh.maNhapHang,
                    t.tenThuoc,
                    nh.donViNhap,
                    nh.giaTriQuyDoi,
                    nh.soLuongNhap,
                    nh.giaNhap,
                    nh.moTa,
                    nh.ngayNhap,
                    (nh.soLuongNhap * nh.giaNhap) AS ThanhTien,
                    nh.userName,
                    t.hamLuong,
                    t.hangSx
                FROM NhapHang nh
                INNER JOIN Thuoc t ON nh.maThuoc = t.maThuoc
                WHERE YEAR(nh.ngayNhap) = @Nam
                ORDER BY nh.ngayNhap";

            SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
            da.SelectCommand.Parameters.AddWithValue("@Nam", nam);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetThongKeNhap()
        {
            string sql = @"
                SELECT 
                nh.maNhapHang,
                t.tenThuoc,
                nh.donViNhap,
                nh.giaTriQuyDoi,
                nh.soLuongNhap,
                nh.giaNhap,
                nh.moTa,
	            nh.ngayNhap,
                (nh.soLuongNhap * nh.giaNhap) AS ThanhTien,
	            nh.userName,
	            t.hamLuong,
	            t.hangSx
                FROM NhapHang nh
                INNER JOIN Thuoc t ON nh.maThuoc = t.maThuoc;";

            SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
