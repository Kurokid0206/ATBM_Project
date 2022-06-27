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
    public partial class frm_YsBs_viewPatient : Form
    {
        public frm_YsBs_viewPatient()
        {
            InitializeComponent();
        }

        private void btn_searchMaBN_Click(object sender, EventArgs e)
        {
            string MaBN = tbMaBN.Text;
            if (MaBN == null || MaBN.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập mã bệnh nhân!", "Thông báo!");
                return;
            }
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd1 = new OracleCommand("CSYT_ADMIN.BACSI_SELECT_BENHNHAN", conn);
                cmd1.CommandType = System.Data.CommandType.StoredProcedure;
                cmd1.Parameters.Add("@MABN", MaBN);
                cmd1.Parameters.Add("@CMND", null);
                cmd1.Parameters.Add("vCHASSIS_RESULT", OracleDbType.RefCursor, ParameterDirection.InputOutput);
                cmd1.ExecuteNonQuery();
                OracleDataAdapter da1 = new OracleDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                gv_viewPatient.DataSource = dt1;
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

        private void btn_searchCMND_Click(object sender, EventArgs e)
        {
            string CMND = tbCMND.Text;
            if (CMND == null || CMND.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập CMND!", "Thông báo!");
                return;
            }
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd2 = new OracleCommand("CSYT_ADMIN.BACSI_SELECT_BENHNHAN", conn);
                cmd2.CommandType = System.Data.CommandType.StoredProcedure;
                cmd2.Parameters.Add("@MABN", null);
                cmd2.Parameters.Add("@CMND", CMND);
                cmd2.Parameters.Add("vCHASSIS_RESULT", OracleDbType.RefCursor, ParameterDirection.InputOutput);
                cmd2.ExecuteNonQuery();
                OracleDataAdapter da2 = new OracleDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                gv_viewPatient.DataSource = dt2;
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
