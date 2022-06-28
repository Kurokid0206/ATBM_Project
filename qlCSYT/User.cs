using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Oracle.DataAccess.Client;
using qlCSYT.SqlConn;

namespace qlCSYT.UserSpace
{
    class User
    {
        public static string username = "NV001";
        public static List<string> Roles = new List<string>();
        public void getRoles() {
            Roles.Clear();
            OracleConnection conn = DBUtils.GetDBConnection();

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("CSYT_ADMIN.GETUSERROLES", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("cur", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                
                DataTable dt = new DataTable();


                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Roles.Add(dr["GRANTED_ROLE"].ToString());
                    
                }

            }
            catch (Exception err)
            {
                Console.WriteLine("Error: " + err);
                Console.WriteLine(err.StackTrace);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            
        }
    }
}
