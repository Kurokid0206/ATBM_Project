using Oracle.DataAccess.Client;

namespace qlCSYT.SqlConn
{
    class DBUtils
    {
        public static string login_username = "";
        public static string login_password = "";

        public static OracleConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 1521;
            string sid = "xe";
            string user = (login_username==""?"CSYT_Admin": login_username);
            string password = (login_password == "" ? "a" : login_password);
            return DBOracleUtils.GetDBConnection(host, port, sid, user, password);
        }
        public static OracleConnection GetDBConnection(string username, string password)
        {
            login_username = "CSYT_"+username;
            login_password = password;

            return GetDBConnection();
        }
    }

}