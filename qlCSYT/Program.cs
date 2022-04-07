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
                

                QueryEmployee(conn);
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
            Application.Run(new frm_Admin());
        }

        private static void QueryEmployee(OracleConnection conn)
        {
            string sql = "Select table_name from user_tables";

            // Tạo một đối tượng Command.
            OracleCommand cmd = new OracleCommand(sql, conn);
            //cmd.Connection = conn;
            //cmd.CommandText = "Select EMPNO,ENAME from C##demo.EMP_19120674";


            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    Console.WriteLine("tbl name");
                    while (reader.Read())
                    {
                        // Chỉ số (index) của cột Emp_ID trong câu lệnh SQL.
                        //int empIdIndex = reader.GetOrdinal("EMPNO"); // 0

                        string tbl_Name = reader.GetString(0);
                        //int empNameIndex = reader.GetOrdinal("EName");// 2
                        //string empName = reader.GetString(empNameIndex);


                        //Console.WriteLine("empIdIndex:" + empIdIndex);
                        Console.WriteLine(tbl_Name);
                        //Console.WriteLine("EmpName:" + empName);
                    }
                }
                else
                {
                    Console.WriteLine("failed");
                }
            }

        }
        private static void ShowTable(OracleConnection conn)
        {
            OracleCommand cmd = new OracleCommand("ShowTables", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("vCHASSIS_RESULT", OracleDbType.RefCursor, ParameterDirection.InputOutput);


            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow dataRow in dt.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }

}