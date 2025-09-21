using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLNT;
using DTO_QLNT;

namespace BUS_QLNT
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dalNhanVien = new DAL_NhanVien();
        public static string userName { get; set; }
        public static string chucvu { get; set; }
        public DataTable getNhanVien()
        {
            return dalNhanVien.getNhanVien();
        }

        public DataTable getNhanVien(string s)
        {
            return dalNhanVien.getNhanVien(s);
        }

        public DataTable timNhanVienTheoUserName(string s)
        {
            return dalNhanVien.timNhanVienTheoUserName(s);
        }
        public string maHoaMD5(string pass)
        {
            return DAL_MaHoaMD5.MaHoaMD5(pass);
        }

        public bool themNhanVien(DTO_NhanVien nv)
        {
            return dalNhanVien.themNhanVien(nv);
        }

        public bool suaNhanVien(DTO_NhanVien nv,int n)
        {
            return dalNhanVien.suaNhanVien(nv, n);
        }

        public bool xoaNhanVien(string userName)
        {
            return dalNhanVien.xoaNhanVien(userName);
        }
    }
}
