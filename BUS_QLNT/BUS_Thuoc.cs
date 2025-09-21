using DAL_QLNT;
using DTO_QLNT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLNT
{
    public class BUS_Thuoc
    {
        DAL_Thuoc dalThuoc = new DAL_Thuoc();

        public DataTable Get()
        {
            return dalThuoc.Get();
        }

        public DataTable Get(string keyword)
        {
            return dalThuoc.Get(keyword);
        }

        public DataTable GetSimple()
        {
            return dalThuoc.GetSimple();
        }

        public DataTable GetWithPrice(int maThuoc)
        {
            return dalThuoc.GetWithPrice(maThuoc);
        }

        public bool Insert(DTO_Thuoc t)
        {
            return dalThuoc.Insert(t);
        }

        public bool Update(DTO_Thuoc t)
        {
            return dalThuoc.Update(t);
        }

        public bool Delete(int maThuoc)
        {
            return dalThuoc.Delete(maThuoc);
        }
    }
}
