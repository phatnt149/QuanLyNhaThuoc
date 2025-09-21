using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_QLNT;
using DTO_QLNT;

namespace BUS_QLNT
{
    public class BUS_ThongKeNhap
    {
        DAL_ThongKeNhap dalThongKeNhap = new DAL_ThongKeNhap();
        public DataTable GetChiTietNhapHangTheoNgay(DateTimePicker tuNgayPicker, DateTimePicker denNgayPicker)
        {
            // Chuyển DateTimePicker sang DateTime
            DateTime tuNgay = tuNgayPicker.Value.Date;
            DateTime denNgay = denNgayPicker.Value.Date;

            return dalThongKeNhap.GetChiTietNhapHangTheoNgay(tuNgay,denNgay);
        }

        public DataTable GetChiTietNhapHangTheoThang(int thang, int nam)
        {
            return dalThongKeNhap.GetChiTietNhapHangTheoThang(thang, nam);
        }

        public DataTable GetChiTietNhapHangTheoNam(int nam)
        {
            return dalThongKeNhap.GetChiTietNhapHangTheoNam(nam);
        }
        public DataTable GetThongKeNhap()
        {
            return dalThongKeNhap.GetThongKeNhap();
        }

    }
}
