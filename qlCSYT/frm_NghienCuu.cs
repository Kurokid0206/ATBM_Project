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

        private void frm_NghienCuu_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void menu_xemHSBADV_Click(object sender, EventArgs e)
        {
            LoadHSBA_DV();
        }
        private void menu_xemHSBA_Click(object sender, EventArgs e)
        {
            LoadHSBA();
        }

        private void LoadHSBA()
        {
            this.gv_NghienCuu.Columns.Clear();
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("ShowAllHSBA", conn);
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

        private void LoadHSBA_DV()
        {
            this.gv_NghienCuu.Columns.Clear();
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("ShowAllHSBA_DV", conn);
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

        private void LoadUsers()
        {
            this.gv_NghienCuu.Columns.Clear();
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("ShowAllUser", conn);
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
    }
}
