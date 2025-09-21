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
    public class BUS_ThongKeBan
    {
        DAL_ThongKeBan dalThongKeBan = new DAL_ThongKeBan();
        public DataTable GetChiTietBanHangTheoNgay(DateTimePicker tuNgayPicker, DateTimePicker denNgayPicker)
        {
            // Chuyển DateTimePicker sang DateTime
            DateTime tuNgay = tuNgayPicker.Value.Date;
            DateTime denNgay = denNgayPicker.Value.Date;

            return dalThongKeBan.GetChiTietBanHangTheoNgay(tuNgay,denNgay);
        }

        public DataTable GetChiTietBanHangTheoThang(int thang, int nam)
        {
            return dalThongKeBan.GetChiTietBanHangTheoThang(thang, nam);
        }

        public DataTable GetChiTietBanHangTheoNam(int nam)
        {
            return dalThongKeBan.GetChiTietBanHangTheoNam(nam);
        }
        public DataTable GetThongKeBan()
        {
            return dalThongKeBan.GetThongKeBan();
        }

    }
}
