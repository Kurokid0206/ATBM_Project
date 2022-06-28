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
    public partial class frmAudit : Form
    {
        public frmAudit()
        {
            InitializeComponent();
        }

        private void frmAudit_Load(object sender, EventArgs e)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("InvalidAccessAudit", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@user_name", "ADMIN");
                cmd.Parameters.Add("vCHASSIS_RESULT", OracleDbType.RefCursor, ParameterDirection.InputOutput);
                cmd.ExecuteNonQuery();

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();


                da.Fill(dt);
                gv_AuditData.DataSource = dt;
            }
            catch (Exception error) { 
                Console.WriteLine(error);
            }
            finally { conn.Close(); }
        }
    }
}
