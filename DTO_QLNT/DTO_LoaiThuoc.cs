using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNT
{
    public class DTO_LoaiThuoc
    {
        public string MaLt { get; set; }
        public string TenLt { get; set; }
        public string MoTa { get; set; }

        public DTO_LoaiThuoc() { }

        public DTO_LoaiThuoc(string maLt, string tenLt, string moTa)
        {
            MaLt = maLt;
            TenLt = tenLt;
            MoTa = moTa;
        }
    }
}
