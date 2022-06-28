using System;
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
            string MAHSBA = MaHSBA_input.Text;
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("CSYT_ADMIN.QLDL_Delete_HSBA", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("MaHSBA", MAHSBA);
               

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Xóa thành công!");
                MaHSBA_input.Text ="";


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
