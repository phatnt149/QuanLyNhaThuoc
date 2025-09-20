using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLNT
{
    public class DAL_MaHoaMD5
    {
        public static string MaHoaMD5(string str)
        {
            Byte[] dauvao = ASCIIEncoding.Default.GetBytes(str);
            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                var daura = md5.ComputeHash(dauvao);
                return BitConverter.ToString(daura);
            }
        }
    }
}
