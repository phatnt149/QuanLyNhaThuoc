using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLNT;

namespace BUS_QLNT
{
    public class BUS_NhapHang
    {
        DAL_NhapHang dalNhapHang = new DAL_NhapHang();

        public System.Data.DataTable Get()
        {
            return dalNhapHang.Get();
        }

        public bool Insert(DTO_QLNT.DTO_NhapHang nh)
        {
            return dalNhapHang.Insert(nh);
        }

        public bool Update(DTO_QLNT.DTO_NhapHang nh)
        {
            return dalNhapHang.Update(nh);
        }

        public bool Delete(int maNhapHang)
        {
            return dalNhapHang.Delete(maNhapHang);
        }
    }
}
