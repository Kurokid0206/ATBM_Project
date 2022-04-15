using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data.Common;
using Oracle.DataAccess.Client;
using qlCSYT.SqlConn;


namespace qlCSYT
{
    public partial class frm_ViewUser : Form
    {
        public frm_ViewUser()
        {
            InitializeComponent();
        }

        private void frm_ViewUser_Load(object sender, EventArgs e)
        {
           
        }
        public void LoadUser(string username)
        {
            
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            OracleCommand cmd = new OracleCommand("ShowPrivilegesForUser", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@user_name", username);
            cmd.Parameters.Add("vCHASSIS_RESULT", OracleDbType.RefCursor, ParameterDirection.InputOutput);
            cmd.ExecuteNonQuery();

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gv_User.DataSource = dt;
        }


        
        
    }
}
