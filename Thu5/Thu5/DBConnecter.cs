using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thu5
{
    class DBConnecter
    {
        public static SqlConnection sqlConnector()
        {
            SqlConnection myConnect = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Quanlybanhanglaptop; Integrated Security=True");
            return myConnect;
        }
    }
}
