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


namespace qlCSYT
{
    class functions
    {
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
