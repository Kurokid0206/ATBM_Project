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


namespace CsOracleTutorial
{

    class QueryDataExample
    {
        [STAThread]
        static void Main(string[] args)
        {
            // Lấy ra đối tượng Connection kết nối vào DB.
            OracleConnection conn = DBUtils.GetDBConnection();

            try
            {
                conn.Open();
                Console.WriteLine(conn.ConnectionString);
                Console.WriteLine("Successful Connection");
                //ShowTable(conn);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            Console.Read();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_addEmp());
        }
    }

}