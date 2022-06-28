using Oracle.DataAccess.Client;
using qlCSYT.SqlConn;
using System;
using System.Data;
using System.Windows.Forms;

namespace qlCSYT
{
    public partial class frm_ThanhTra : Form
    {
        public frm_ThanhTra()
        {
            InitializeComponent();
        }

        private void menu_logout_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            f.Show();
            this.Close();
        }

        private void menu_xemHSBA_Click(object sender, EventArgs e)
        {
            SelectHSBA();
        }

        private void menu_xemHSBA_DV_Click(object sender, EventArgs e)
        {
            SelectHSBA_DV();
        }

        private void menu_xemBenhNhan_Click(object sender, EventArgs e)
        {
            SelectBenhNhan();
        }

        private void menu_xemCSYT_Click(object sender, EventArgs e)
        {
            SelectCSYT();
        }

        private void menu_xemNhanVien_Click(object sender, EventArgs e)
        {
            SelectNhanVien();
        }

        private void SelectHSBA()
        {
            this.gv_ThanhTra.Columns.Clear();
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("CSYT_Admin.TT_Select_HSBA", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@user_name", "ADMIN");
                cmd.Parameters.Add("vCHASSIS_RESULT", OracleDbType.RefCursor, ParameterDirection.InputOutput);
                cmd.ExecuteNonQuery();

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                gv_ThanhTra.DataSource = dt;
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

        private void SelectHSBA_DV()
        {
            this.gv_ThanhTra.Columns.Clear();
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("CSYT_Admin.TT_Select_HSBA_DV", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@user_name", "ADMIN");
                cmd.Parameters.Add("vCHASSIS_RESULT", OracleDbType.RefCursor, ParameterDirection.InputOutput);
                cmd.ExecuteNonQuery();

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                gv_ThanhTra.DataSource = dt;
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

        private void SelectBenhNhan()
        {
            this.gv_ThanhTra.Columns.Clear();
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("CSYT_Admin.TT_Select_BenhNhan", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@user_name", "ADMIN");
                cmd.Parameters.Add("vCHASSIS_RESULT", OracleDbType.RefCursor, ParameterDirection.InputOutput);
                cmd.ExecuteNonQuery();

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                gv_ThanhTra.DataSource = dt;
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

        private void SelectCSYT()
        {
            this.gv_ThanhTra.Columns.Clear();
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("CSYT_Admin.TT_Select_CSYT", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@user_name", "ADMIN");
                cmd.Parameters.Add("vCHASSIS_RESULT", OracleDbType.RefCursor, ParameterDirection.InputOutput);
                cmd.ExecuteNonQuery();

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                gv_ThanhTra.DataSource = dt;
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

        private void SelectNhanVien()
        {
            this.gv_ThanhTra.Columns.Clear();
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("CSYT_Admin.TT_Select_NhanVien", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@user_name", "ADMIN");
                cmd.Parameters.Add("vCHASSIS_RESULT", OracleDbType.RefCursor, ParameterDirection.InputOutput);
                cmd.ExecuteNonQuery();

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                gv_ThanhTra.DataSource = dt;
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
