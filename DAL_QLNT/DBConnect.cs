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
        protected SqlConnection _conn = new SqlConnection("Data Source=CONGCHUAHIEP;Initial Catalog=QLNT;Integrated Security=True;Encrypt=False");
    }
}
