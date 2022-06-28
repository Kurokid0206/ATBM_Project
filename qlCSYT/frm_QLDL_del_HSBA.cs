ausing System;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using qlCSYT.SqlConn;
using System.Data;

namespace qlCSYT
{
    public partial class frm_QLDL_del_HSBA : Form
    {
        public frm_QLDL_del_HSBA()
        {
            InitializeComponent();
        }


        private void del_HSBA_btn_Click(object sender, EventArgs e)
        {
           /* OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("CSYT_ADMIN.QLDL_Delete_HSBA", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("MaHSBA", MaBN);
                var pid = DateTime.ParseExact(NgayLap, "dd-MM-yyyy", null);
                cmd.Parameters.Add("Ngay", OracleDbType.Date).Value = pid;
                cmd.Parameters.Add("ChanDoan", ChanDoan);
                cmd.Parameters.Add("MaBS", MaBS);
                cmd.Parameters.Add("MaKHOA", MaKhoa);
                cmd.Parameters.Add("KetLuan", KetLuan);

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();

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
            }*/
        }
    }
}
