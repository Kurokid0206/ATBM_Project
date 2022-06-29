using System;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using qlCSYT.SqlConn;

namespace qlCSYT
{
    public partial class frm_QLDL_main : Form
    {
        public frm_QLDL_main()
        {
            InitializeComponent();
        }

        private void add_HSBA_btn_Click(object sender, EventArgs e)
        {
            string MaBN= MaBN_input.Text ;
            string NgayLap = NgayLap_input.Value.ToString("dd-MM-yyyy");
            string MaKhoa = MaKhoa_input.Text;
            string MaBS = MaBS_input.Text;
            string ChanDoan = ChanDoan_input.Text;
            string KetLuan = KetLuan_input.Text;
            OracleConnection conn = DBUtils.GetDBConnection();

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("CSYT_Admin.QLDL_Insert_HSBA", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("MaBN",MaBN);
                var pid = DateTime.ParseExact(NgayLap, "dd-MM-yyyy", null);
                cmd.Parameters.Add("Ngay", OracleDbType.Date).Value = pid;
                cmd.Parameters.Add("ChanDoan", ChanDoan);
                cmd.Parameters.Add("MaBS", MaBS);
                cmd.Parameters.Add("MaKHOA", MaKhoa);
                cmd.Parameters.Add("KetLuan", KetLuan);

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

        private void add_HSBA_strip_Click(object sender, EventArgs e)
        {
            
        }

        private void del_HSBA_strip_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_QLDL_del_HSBA frm_del_hsba = new frm_QLDL_del_HSBA();
            frm_del_hsba.Show();
            frm_del_hsba.Closed += (s, args) => this.Show();

            //
        }

        private void add_HSBADV_strip_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_QLDL_add_HSBA_DV frm_QLDL_add_HSBA_DV = new frm_QLDL_add_HSBA_DV();
            frm_QLDL_add_HSBA_DV.Show();
            frm_QLDL_add_HSBA_DV.Closed += (s, args) => this.Show();
        }

        private void del_HSBADV_strip_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            frm_QLDL_del_HSBA_DV frm_QLDL_del_HSBA_DV = new frm_QLDL_del_HSBA_DV();
            frm_QLDL_del_HSBA_DV.Show();
            frm_QLDL_del_HSBA_DV.Closed += (s, args) => this.Show();
        }
    }
}
