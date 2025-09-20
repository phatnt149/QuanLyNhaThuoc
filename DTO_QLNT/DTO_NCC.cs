using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNT
{
    public class DTO_NCC
    {
        public int MaNcc { get; set; }
        public string TenNcc { get; set; }
        public string LoaiNcc { get; set; }
        public string MoTa { get; set; }

        // Constructor mặc định
        public DTO_NCC() { }

        // Constructor đầy đủ
        public DTO_NCC(int maNcc, string tenNcc, string loaiNcc, string moTa)
        {
            MaNcc = maNcc;
            TenNcc = tenNcc;
            LoaiNcc = loaiNcc;
            MoTa = moTa;
        }
    }
}
