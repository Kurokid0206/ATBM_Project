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
    public partial class frm_ViewRole : Form
    {
        public frm_ViewRole()
        {
            InitializeComponent();
        }

        private void Frm_Edit_Roles_Load(object sender, EventArgs e)
        {

        }

        public void LoadRole(string rolename)
        {

            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            OracleCommand cmd = new OracleCommand("ShowRolePriv", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@roleName", rolename);
            cmd.Parameters.Add("vCHASSIS_RESULT", OracleDbType.RefCursor, ParameterDirection.InputOutput);
            cmd.ExecuteNonQuery();

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView_ShowRole.DataSource = dt;
        }
    }
}
