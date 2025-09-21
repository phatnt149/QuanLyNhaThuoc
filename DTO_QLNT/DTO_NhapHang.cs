using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DTO_QLNT
{
    public class DTO_NhapHang
    {
        public int MaNhapHang { get; set; }
        public int MaThuoc { get; set; }
        public string DonViNhap { get; set; }
        public int GiaTriQuyDoi { get; set; }
        public int SoLuongNhap { get; set; }
        public decimal GiaNhap { get; set; }
        public string MoTa { get; set; }
        public DateTime NgayNhap { get; set; }
        public decimal ThanhTien { get; set; }
        public string UserName { get; set; }

        public DTO_NhapHang() { }

        public DTO_NhapHang(int maNhapHang, int maThuoc, string donViNhap, int giaTriQuyDoi, int soLuongNhap, decimal giaNhap, string moTa, DateTime ngayNhap, decimal thanhTien, string userName)
        {
            MaNhapHang = maNhapHang;
            MaThuoc = maThuoc;
            DonViNhap = donViNhap;
            GiaTriQuyDoi = giaTriQuyDoi;
            SoLuongNhap = soLuongNhap;
            GiaNhap = giaNhap;
            MoTa = moTa;
            NgayNhap = ngayNhap;
            ThanhTien = thanhTien;
            UserName = userName;
        }


    }
}
