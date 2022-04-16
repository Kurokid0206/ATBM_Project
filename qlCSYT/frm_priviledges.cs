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
            try { 
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
                catch (Exception) { }
                finally { conn.Close(); }
        }
        private void loadRoles()
        {

            OracleConnection conn = DBUtils.GetDBConnection();
            try { 
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
                catch (Exception) { }
                finally { conn.Close(); }
        }
        private void loadTables()
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            try { 
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
                catch (Exception) { }
                finally { conn.Close(); }

        }
        private void OnIndexChanged(object sender, EventArgs e)
        {
            loadTableCol(cb_tblList.SelectedValue.ToString());
        }
        void Grant_Select_From_Grid_View_Button(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == gv_tables.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            if (e.ColumnIndex == gv_tables.Columns["dataGridView_btn_select"].Index)
            {
                DataGridViewRow row = gv_tables.Rows[e.RowIndex];
     
                OracleConnection conn = DBUtils.GetDBConnection();
                try { 
                conn.Open();
                OracleCommand cmd = new OracleCommand("GrantSelect", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                string user_role = "";
                if (rbtn_user.Checked) { user_role = cb_user.SelectedValue.ToString(); }
                else { user_role = cb_roles.SelectedValue.ToString(); }
                cmd.Parameters.Add("@user_role", user_role);
                cmd.Parameters.Add("@cols", row.Cells[0].Value.ToString());
                cmd.Parameters.Add("@table_priv", cb_tblList.SelectedValue.ToString());
                cmd.Parameters.Add("@opt", GrantOpt_btn.Checked.ToString());
                /*                Console.WriteLine(cb_user.SelectedValue.ToString());
                                Console.WriteLine(row.Cells[0].Value.ToString());
                                Console.WriteLine(cb_tblList.SelectedValue.ToString());
                                Console.WriteLine(GrantOpt_btn.Checked.ToString());*/

                cmd.ExecuteNonQuery();
            }
                catch (Exception) { }
            finally { conn.Close(); }

        }
        }
        void Grant_Update_From_Grid_View_Button(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == gv_tables.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            if (e.ColumnIndex == gv_tables.Columns["dataGridView_btn_update"].Index)
            {
                DataGridViewRow row = gv_tables.Rows[e.RowIndex];
                
                OracleConnection conn = DBUtils.GetDBConnection();
                try
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("GrantUpdate", conn);
                    string user_role = "";
                    if (rbtn_user.Checked) { user_role = cb_user.SelectedValue.ToString(); }
                    else { user_role = cb_roles.SelectedValue.ToString(); }
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@user_role", user_role);
                    cmd.Parameters.Add("@cols", row.Cells[0].Value.ToString());
                    cmd.Parameters.Add("@table_priv", cb_tblList.SelectedValue.ToString());
                    cmd.Parameters.Add("@opt", GrantOpt_btn.Checked.ToString());

                    cmd.ExecuteNonQuery();
                }
                catch (Exception) { }
                finally { conn.Close(); }
            }
        }
        private void loadTableCol(string tblName)
        {
            gv_tables.Columns.Clear();
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


            var grant_select_button = new DataGridViewButtonColumn();
             
                grant_select_button.Name = "dataGridView_btn_select";
                grant_select_button.HeaderText = "Grant select";
                grant_select_button.Text = "Grant";
                grant_select_button.UseColumnTextForButtonValue = true; //dont forget this line
                this.gv_tables.Columns.Add(grant_select_button);

                gv_tables.CellClick += Grant_Select_From_Grid_View_Button;
                
            
            var grant_update_button = new DataGridViewButtonColumn();
             
                grant_update_button.Name = "dataGridView_btn_update";
                grant_update_button.HeaderText = "Grant Update";
                grant_update_button.Text = "Grant";
                grant_update_button.UseColumnTextForButtonValue = true; //dont forget this line
                this.gv_tables.Columns.Add(grant_update_button);

                gv_tables.CellClick += Grant_Update_From_Grid_View_Button;
                
            
        }
       
        private void rbtn_user_CheckedChanged(object sender, EventArgs e)
        {
            cb_user.Enabled = true;
            cb_roles.Enabled = false;
            GrantOpt_btn.Enabled = true;
        }

        private void rbtn_role_CheckedChanged(object sender, EventArgs e)
        {
            cb_user.Enabled = false;
            cb_roles.Enabled = true;
            GrantOpt_btn.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cb_user_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_addDelPriv_Click(object sender, EventArgs e)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            OracleCommand cmd = new OracleCommand("GrantDelete", conn);
            string user_role = "";
            if (rbtn_user.Checked) { user_role = cb_user.SelectedValue.ToString(); }
            else { user_role = cb_roles.SelectedValue.ToString(); }
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@user_role", user_role); 
            cmd.Parameters.Add("@table_priv", cb_tblList.SelectedValue.ToString());
            cmd.Parameters.Add("@opt", GrantOpt_btn.Checked.ToString());

            cmd.ExecuteNonQuery();
        }

        private void btn_addInsPriv_Click(object sender, EventArgs e)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            OracleCommand cmd = new OracleCommand("GrantInsert", conn);
            string user_role = "";
            if (rbtn_user.Checked) { user_role = cb_user.SelectedValue.ToString(); }
            else { user_role = cb_roles.SelectedValue.ToString(); }
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@user_role", user_role);
            cmd.Parameters.Add("@table_priv", cb_tblList.SelectedValue.ToString());
            cmd.Parameters.Add("@opt", GrantOpt_btn.Checked.ToString());

            cmd.ExecuteNonQuery();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn hủy thao tác?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK) this.Close();
        }
    }
}