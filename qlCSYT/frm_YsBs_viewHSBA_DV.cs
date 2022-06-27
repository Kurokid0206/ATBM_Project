using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using qlCSYT.SqlConn;

namespace qlCSYT
{
    public partial class frm_YsBs_viewHSBA_DV : Form
    {
        private string curID = "";
        public frm_YsBs_viewHSBA_DV()
        {
            InitializeComponent();
            LoadHSBA_DV(curID);
        }
        public void LoadHSBA_DV(string MaHSBA)
        {
            curID = MaHSBA;
            gv_HSBA_DV.Columns.Clear();
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                string temp = "Select * from CSYT_ADMIN.VIEW_BACSI_HSBA_DV dv where dv.MaHSBA=";
                //string cmdtext = temp + "'" + MaHSBA + "'";
                //string cmdtext = temp + "'" + curID + "'";
                string cmdtext = temp + "'" + MaHSBA + "'";
                OracleCommand cmd = new OracleCommand(cmdtext, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@roleName", MaHSBA);
                //cmd.Parameters.Add("vCHASSIS_RESULT", OracleDbType.RefCursor, ParameterDirection.InputOutput);
                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gv_HSBA_DV.DataSource = dt;
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
