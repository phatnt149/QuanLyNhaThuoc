using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNT
{
    public class DTO_NhanVien
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public byte[] HinhAnh { get; set; }
        public string ChucVu { get; set; }

        // Constructor mặc định
        public DTO_NhanVien() { }

        public DTO_NhanVien(string userName, string hoTen)
        {
            UserName = userName;
            HoTen = hoTen;
        }

        // Constructor đầy đủ
        public DTO_NhanVien(string userName, string passWord, string hoTen,
                            DateTime ngaySinh, string gioiTinh, string diaChi,
                            byte[] hinhAnh, string chucVu)
        {
            UserName = userName;
            PassWord = passWord;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            HinhAnh = hinhAnh;
            ChucVu = chucVu;
        }
    }
}
