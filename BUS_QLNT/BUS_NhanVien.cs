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

        public bool suaNhanVien(DTO_NhanVien nv)
        {
            return dalNhanVien.suaNhanVien(nv);
        }

        public bool xoaNhanVien(string userName)
        {
            return dalNhanVien.xoaNhanVien(userName);
        }

        /// <summary>
        /// Xử lý đăng nhập người dùng
        /// 
        /// Mật khẩu của người dùng sẽ được băm bằng mã hoá MD5
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        /// <exception cref="Exception">Nếu sai tên đăng nhập, mật khẩu, tài khoản không tồn tại</exception>
        public DTO_NhanVien DangNhap(string userName, string passWord)
        {
            string hassedPass = maHoaMD5(passWord);
            Console.WriteLine(hassedPass);
            DTO_NhanVien user = dalNhanVien.DangNhap(userName, hassedPass);
            if (user != null)
            {
                return user;
            }
            else
            {
                throw new Exception("Đăng nhập thất bại, vui lòng kiểm tra lại tên đăng nhập và mật khẩu.");
            }
        }
    }
}
