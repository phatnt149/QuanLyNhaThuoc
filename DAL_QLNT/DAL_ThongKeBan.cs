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
    public class DAL_ThongKeBan : DBConnect
    {
        public DataTable GetChiTietBanHangTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            string sql = @"
        SELECT 
            hd.maHd,
            kh.hoTen,
            hd.trangThai,
            hd.userName,
            hd.gioThanhToan,
            t.maThuoc,
            t.tenThuoc,
            t.hamLuong,
            t.hangSx,
            cthd.maCthd,
            t.donViBan,
            cthd.soLuong,
            cthd.giaBanTheoDonVi,
            (cthd.soLuong * cthd.giaBanTheoDonVi) AS thanhTien
        FROM dbo.HoaDon hd
        JOIN dbo.KhachHang kh ON hd.maKh = kh.maKh
        JOIN dbo.ChiTietHD cthd ON hd.maHd = cthd.maHd
        JOIN dbo.Thuoc t ON cthd.maThuoc = t.maThuoc
        WHERE CAST(hd.gioThanhToan AS DATE) BETWEEN @tuNgay AND @denNgay
        ORDER BY hd.gioThanhToan";

            SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
            da.SelectCommand.Parameters.AddWithValue("@tuNgay", tuNgay.Date);
            da.SelectCommand.Parameters.AddWithValue("@denNgay", denNgay.Date);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        
        public DataTable GetChiTietBanHangTheoThang(int thang, int nam)
        {
            string sql = @"
        SELECT 
            hd.maHd,
            kh.hoTen,
            hd.trangThai,
            hd.userName,
            hd.gioThanhToan,
            t.maThuoc,
            t.tenThuoc,
            t.hamLuong,
            t.hangSx,
            cthd.maCthd,
            t.donViBan,
            cthd.soLuong,
            cthd.giaBanTheoDonVi,
            (cthd.soLuong * cthd.giaBanTheoDonVi) AS thanhTien
        FROM dbo.HoaDon hd
        JOIN dbo.KhachHang kh ON hd.maKh = kh.maKh
        JOIN dbo.ChiTietHD cthd ON hd.maHd = cthd.maHd
        JOIN dbo.Thuoc t ON cthd.maThuoc = t.maThuoc
        WHERE MONTH(hd.gioThanhToan) = @Thang 
          AND YEAR(hd.gioThanhToan) = @Nam
        ORDER BY hd.gioThanhToan";

            SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
            da.SelectCommand.Parameters.AddWithValue("@Thang", thang);
            da.SelectCommand.Parameters.AddWithValue("@Nam", nam);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public DataTable GetChiTietBanHangTheoNam(int nam)
        {
            string sql = @"
                SELECT 
                hd.maHd,
                kh.hoTen,
                hd.trangThai,
                hd.userName,
                hd.gioThanhToan,
                t.maThuoc,
                t.tenThuoc,
                t.hamLuong,
                t.hangSx,
                cthd.maCthd,
                t.donViBan,
                cthd.soLuong,
                cthd.giaBanTheoDonVi,
                (cthd.soLuong * cthd.giaBanTheoDonVi) AS thanhTien
                FROM dbo.HoaDon hd
                JOIN dbo.KhachHang kh ON hd.maKh = kh.maKh
                JOIN dbo.ChiTietHD cthd ON hd.maHd = cthd.maHd
                JOIN dbo.Thuoc t ON cthd.maThuoc = t.maThuoc
                WHERE YEAR(hd.gioThanhToan) = @Nam
                ORDER BY hd.gioThanhToan";

            SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
            da.SelectCommand.Parameters.AddWithValue("@Nam", nam);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetThongKeBan()
        {
            string sql = @"
                SELECT 
                hd.maHd,
                kh.hoTen,
                hd.trangThai,
                hd.userName,
                hd.gioThanhToan,
                t.maThuoc,
                t.tenThuoc,
                t.hamLuong,
                t.hangSx,
                cthd.maCthd,
                t.donViBan,
                cthd.soLuong,
                cthd.giaBanTheoDonVi,
                (cthd.soLuong * cthd.giaBanTheoDonVi) AS thanhTien
                FROM dbo.HoaDon hd
                JOIN dbo.KhachHang kh ON hd.maKh = kh.maKh
                JOIN dbo.ChiTietHD cthd ON hd.maHd = cthd.maHd
                JOIN dbo.Thuoc t ON cthd.maThuoc = t.maThuoc";

            SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
