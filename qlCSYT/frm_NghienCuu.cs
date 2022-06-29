using Oracle.DataAccess.Client;
using qlCSYT.SqlConn;
using System;
using System.Data;
using System.Windows.Forms;

namespace qlCSYT
{
    public partial class frm_NghienCuu : Form
    {
        public frm_NghienCuu()
        {
            InitializeComponent();
        }
        private void menu_xemHSBADV_Click(object sender, EventArgs e)
        {
            ViewHSBA_DV();
        }
        private void menu_xemHSBA_Click(object sender, EventArgs e)
        {
            ViewHSBA();
        }
        private void ViewHSBA()
        {
            this.gv_NghienCuu.Columns.Clear();
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("CSYT_Admin.NC_View_HSBA", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@user_name", "ADMIN");
                cmd.Parameters.Add("vCHASSIS_RESULT", OracleDbType.RefCursor, ParameterDirection.InputOutput);
                cmd.ExecuteNonQuery();

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                gv_NghienCuu.DataSource = dt;
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ViewHSBA_DV()
        {
            this.gv_NghienCuu.Columns.Clear();
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("CSYT_Admin.NC_View_HSBA_DV", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@user_name", "ADMIN");
                cmd.Parameters.Add("vCHASSIS_RESULT", OracleDbType.RefCursor, ParameterDirection.InputOutput);
                cmd.ExecuteNonQuery();

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();


                da.Fill(dt);
                gv_NghienCuu.DataSource = dt;
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
            finally
            {

                conn.Close();
            }
        }

        private void menu_logout_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            f.Show();
            this.Close();
        }
    }
}
