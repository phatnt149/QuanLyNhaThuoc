using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL_QLNT
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("Data Source=TIENPHAT;Initial Catalog=QLNT_FIXED;Integrated Security=True;Encrypt=False");
    }
}
