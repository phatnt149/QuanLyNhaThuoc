using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLNT;

namespace BUS_QLNT
{
    public class BUS_LoaiThuoc
    {
        DAL_LoaiThuoc dalLoaiThuoc = new DAL_LoaiThuoc();

        public System.Data.DataTable Get()
        {
            return dalLoaiThuoc.Get();
        }

        public System.Data.DataTable Get(int id)
        {
            return dalLoaiThuoc.Get(id);
        }
    }
}
