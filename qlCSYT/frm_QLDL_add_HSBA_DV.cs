using System;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using qlCSYT.SqlConn;

namespace qlCSYT
{
    public partial class frm_QLDL_add_HSBA_DV : Form
    {
        public frm_QLDL_add_HSBA_DV()
        {
            InitializeComponent();
        }

        private void add_HSBA_DV_btn_Click(object sender, EventArgs e)
        {
            string MaHSBA = MaHSBA_input.Text;
            string NgayLap = NgayLap_DV_input.Value.ToString("dd-MM-yyyy");
            string MaDV = MADV_input.Text;
            string MaKTV = MAKTV_input.Text;
            string KetQua = KetQua_input.Text;
            OracleConnection conn = DBUtils.GetDBConnection();

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("CSYT_Admin.QLDL_Insert_HSBA_DV", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("MaHSBA", MaHSBA);
                cmd.Parameters.Add("MaDV", MaDV);
                var pid = DateTime.ParseExact(NgayLap, "dd-MM-yyyy", null);
                cmd.Parameters.Add("Ngay", OracleDbType.Date).Value = pid;
                cmd.Parameters.Add("MaKTV", MaKTV);
                cmd.Parameters.Add("KetQua", KetQua);

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm thành công!", "Thông báo!");
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
            this.Controls.Clear();
            this.InitializeComponent();
        }
    }
}
