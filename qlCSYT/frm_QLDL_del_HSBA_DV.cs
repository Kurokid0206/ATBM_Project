using System;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using qlCSYT.SqlConn;

namespace qlCSYT
{
    public partial class frm_QLDL_del_HSBA_DV : Form
    {
        public frm_QLDL_del_HSBA_DV()
        {
            InitializeComponent();
        }

        private void del_HSBA_btn_Click(object sender, EventArgs e)
        {
            string MaHSBA = MaHSBA_del_input.Text;
            string MaDV = MaDV_input.Text;
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("CSYT_ADMIN.QLDL_Delete_HSBA_DV", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("MAHSBA", MaHSBA);
                cmd.Parameters.Add("MADV", MaDV);

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Xóa thành công!", "Thông báo!");
                MaHSBA_del_input.Text = "";
                MaDV_input.Text = "";


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
