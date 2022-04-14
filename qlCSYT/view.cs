using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.SqlConn;
using System.Data;
using System.Data.Common;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

using System.Windows.Forms;
using qlCSYT;

namespace view
{
    class viewclass
    {
        static void view()
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            OracleCommand cmd = conn.CreateCommand();
            string sql ="";
            cmd.CommandText = sql;

        }
    }
}
