using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlCSYT.SqlConn;
using System.Data.Common;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using qlCSYT;

namespace qlCSYT
{
    public partial class frm_priviledges : Form
    {
        public frm_priviledges()
        {
            InitializeComponent();
        }

        private void frm_priviledges_Load(object sender, EventArgs e)
        {
            loadUsers();
            loadTables();
            loadRoles();
            loadTableCol("HSBA");
            rbtn_user.Checked = true;
        }
        private void loadUsers()
        {
            
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            OracleCommand cmd = new OracleCommand("ShowAllUser", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Parameters.Add("@user_name", "ADMIN");
            cmd.Parameters.Add("vCHASSIS_RESULT", OracleDbType.RefCursor, ParameterDirection.InputOutput);
            cmd.ExecuteNonQuery();

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();


            da.Fill(dt);
            cb_user.DataSource = dt;
            cb_user.DisplayMember = "USERNAME";
            cb_user.ValueMember = "USERNAME";
        }
        private void loadRoles()
        {

            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            OracleCommand cmd = new OracleCommand("ShowAllRole", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Parameters.Add("@user_name", "ADMIN");
            cmd.Parameters.Add("vCHASSIS_RESULT", OracleDbType.RefCursor, ParameterDirection.InputOutput);
            cmd.ExecuteNonQuery();

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();


            da.Fill(dt);
            cb_roles.DataSource = dt;
            cb_roles.DisplayMember = "ROLE";
            cb_roles.ValueMember = "ROLE";
        }
        private void loadTables()
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            OracleCommand cmd = new OracleCommand("ShowTables", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("vCHASSIS_RESULT", OracleDbType.RefCursor, ParameterDirection.InputOutput);
            cmd.ExecuteNonQuery();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb_tblList.DataSource = dt;
            cb_tblList.DisplayMember = "table_name";
            cb_tblList.ValueMember = "table_name";
            cb_tblList.SelectedIndexChanged += OnIndexChanged;


        }
        private void OnIndexChanged(object sender, EventArgs e)
        {
            loadTableCol(cb_tblList.SelectedValue.ToString());
        }
        private void loadTableCol(string tblName)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            OracleCommand cmd = new OracleCommand("ShowTableCol", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@tblname", tblName);
            cmd.Parameters.Add("vCHASSIS_RESULT", OracleDbType.RefCursor, ParameterDirection.InputOutput);
            cmd.ExecuteNonQuery();

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            gv_tables.DataSource = dt;

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "btn_delete";
                button.HeaderText = "Delete";
                button.Text = "Delete";
                button.UseColumnTextForButtonValue = true; //dont forget this line
                this.gv_tables.Columns.Add(button);
            }
        }

        private void rbtn_user_CheckedChanged(object sender, EventArgs e)
        {
            cb_user.Enabled=true;
            cb_roles.Enabled = false;
        }

        private void rbtn_role_CheckedChanged(object sender, EventArgs e)
        {
            cb_user.Enabled = false;
            cb_roles.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
