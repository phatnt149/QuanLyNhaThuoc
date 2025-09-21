using System;

namespace DTO_QLNT
{
    public class DTO_Thuoc
    {
        public int MaThuoc { get; set; }
        public int MaLt { get; set; }
        public int MaNcc { get; set; }
        public string TenThuoc { get; set; }
        public string HamLuong { get; set; }
        public string QuyCachDongGoi { get; set; }
        public string HangSx { get; set; }
        public string DonViCoBan { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaBan { get; set; }
        public string MoTa { get; set; }
        public byte[] HinhAnh { get; set; }
        public DateTime HanSd { get; set; }
        public string DonViBan { get; set; }
        public int GiaTriQuyDoi { get; set; }
        public decimal GiaBanTheoDvBan { get; set; }
        public int SoLuongTheoDvBan { get; set; }

        public DTO_Thuoc() { }

        public DTO_Thuoc(
            int maThuoc,
            int maLt,
            int maNcc,
            string tenThuoc,
            string hamLuong,
            string quyCachDongGoi,
            string hangSx, 
            string donViCoBan, 
            int soLuong, 
            decimal giaBan,
            string moTa, 
            byte[] hinhAnh, 
            DateTime hanSd,
            string donViBan, 
            int giaTriQuyDoi, 
            decimal giaBanTheoDvBan, 
            int soLuongTheoDvBan)
        {
            MaThuoc = maThuoc;
            MaLt = maLt;
            MaNcc = maNcc;
            TenThuoc = tenThuoc;
            HamLuong = hamLuong;
            QuyCachDongGoi = quyCachDongGoi;
            HangSx = hangSx;
            DonViCoBan = donViCoBan;
            SoLuong = soLuong;
            GiaBan = giaBan;
            MoTa = moTa;
            HinhAnh = hinhAnh;
            HanSd = hanSd;
            DonViBan = donViBan;
            GiaTriQuyDoi = giaTriQuyDoi;
            GiaBanTheoDvBan = giaBanTheoDvBan;
            SoLuongTheoDvBan = soLuongTheoDvBan;
        }
    }
}