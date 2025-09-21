using System;
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
    public class BUS_NhaCC
    {
        DAL_NCC dalNhaCC = new DAL_NCC();
        public DataTable getNhaCC()
        {
            return dalNhaCC.getNCC();
        }

        public DataTable getNhaCC(string s)
        {
            return dalNhaCC.getNCC(s);
        }

        public DataTable timNhaCCTheoMaNcc(int s)
        {
            return dalNhaCC.timNhaCCTheoMaNcc(s);
        }
     
        public bool themNhaCC(DTO_NCC ncc)
        {
            return dalNhaCC.themNhaCC(ncc);
        }

        public bool suaNhaCC(DTO_NCC ncc)
        {
            return dalNhaCC.suaNhaCC(ncc);
        }

        public bool xoaNhaCC(int s)
        {
            return dalNhaCC.xoaNhaCC(s);
        }

    }
}
