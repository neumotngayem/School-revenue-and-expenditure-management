using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAOVO_QLTC
{
    class DBUtils
    {
        public static SqlConnection getConnection()
        {
            String connString = "Data Source=KYOHB;Initial Catalog=DaoVo_QLTCTH;Integrated Security=True";
            return new SqlConnection(connString);
        }
    }
}
