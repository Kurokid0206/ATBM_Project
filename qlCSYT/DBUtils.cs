using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace Tutorial.SqlConn
{
    class DBUtils
    {
        public static OracleConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 1521;
            string sid = "xe";
            string user = "C##demo";
            string password = "demo";
            return DBOracleUtils.GetDBConnection(host, port, sid, user, password);
        }
        
    }

}