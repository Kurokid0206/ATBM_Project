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
        private string curRole = "";
        public frm_ViewRole()
        {
            InitializeComponent();
        }

        private void Frm_Edit_Roles_Load(object sender, EventArgs e)
        {

        }

        public void LoadRole(string rolename)
        {
            curRole = rolename;
            GridView_ShowRole.Columns.Clear();
            OracleConnection conn = DBUtils.GetDBConnection();
            try { 
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
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
            finally
            {

                conn.Close();
            }
            //Revoke button
            var revokeButton = new DataGridViewButtonColumn();
            revokeButton.Name = "dataGridViewRoleRevokeButton";
            revokeButton.HeaderText = "REVOKE";
            revokeButton.Text = "x";
            revokeButton.UseColumnTextForButtonValue = true;
            this.GridView_ShowRole.Columns.Add(revokeButton);
            GridView_ShowRole.CellClick -= DataGridViewRole_RevokeCellClick;
            GridView_ShowRole.CellClick += DataGridViewRole_RevokeCellClick;


            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("SHOWUPDATEPRIVILEGESFORUSER", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@user_name", rolename);
                cmd.Parameters.Add("vCHASSIS_RESULT", OracleDbType.RefCursor, ParameterDirection.InputOutput);
                cmd.ExecuteNonQuery();

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gv_Update_col_priv.DataSource = dt;


            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
            finally
            {

                conn.Close();
            }
            var revokeButton2 = new DataGridViewButtonColumn();
            revokeButton2.Name = "dataGridViewUserRevokeButton";
            revokeButton2.HeaderText = "REVOKE";
            revokeButton2.Text = "x";
            revokeButton2.UseColumnTextForButtonValue = true;
            this.gv_Update_col_priv.Columns.Add(revokeButton2);
            gv_Update_col_priv.CellClick -= DataGridViewUser_RevokeUpdateCellClick;
            gv_Update_col_priv.CellClick += DataGridViewUser_RevokeUpdateCellClick;
        }
        void DataGridViewUser_RevokeUpdateCellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == gv_Update_col_priv.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            if (e.ColumnIndex == gv_Update_col_priv.Columns["dataGridViewUserRevokeButton"].Index)
            {
                string username = gv_Update_col_priv.Rows[e.RowIndex].Cells[0].Value.ToString();
                string priviledge = gv_Update_col_priv.Rows[e.RowIndex].Cells[2].Value.ToString();
                string obj = gv_Update_col_priv.Rows[e.RowIndex].Cells[1].Value.ToString();

                OracleConnection conn = DBUtils.GetDBConnection();
                Console.WriteLine(username);
                //Console.WriteLine(pinteger);
                Console.WriteLine(obj);
                try
                {
                    conn.Open();
                    int pinteger;
                    pinteger = -1;
                    if (priviledge == "INSERT") pinteger = 0;
                    if (priviledge == "SELECT") pinteger = 1;
                    if (priviledge == "UPDATE") pinteger = 2;
                    if (priviledge == "DELETE") pinteger = 3;
                    OracleCommand cmd = new OracleCommand("revokePrivilege", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@pi_username", username);
                    cmd.Parameters.Add("@pi_priType", pinteger);
                    cmd.Parameters.Add("@pi_obj", obj);

                    cmd.ExecuteNonQuery();

                }
                catch (Exception err)
                {
                    Console.WriteLine(err);
                }
                finally { conn.Close(); }
                LoadRole(curRole);
            }
        }
        void DataGridViewRole_RevokeCellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == GridView_ShowRole.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            if (e.ColumnIndex == GridView_ShowRole.Columns["dataGridViewRoleRevokeButton"].Index)
            {
                string username = GridView_ShowRole.Rows[e.RowIndex].Cells[0].Value.ToString();
                string priviledge = GridView_ShowRole.Rows[e.RowIndex].Cells[2].Value.ToString();
                string obj = GridView_ShowRole.Rows[e.RowIndex].Cells[1].Value.ToString();
                OracleConnection conn = DBUtils.GetDBConnection();
                try
                {
                    conn.Open();
                    int pinteger;
                    pinteger = -1;
                    if (priviledge == "INSERT") pinteger = 0;
                    if (priviledge == "SELECT") pinteger = 1;
                    if (priviledge == "UPDATE") pinteger = 2;
                    if (priviledge == "DELETE") pinteger = 3;
                    OracleCommand cmd = new OracleCommand("revokePrivilege", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@pi_username", username);
                    cmd.Parameters.Add("@pi_priType", pinteger);
                    cmd.Parameters.Add("@pi_obj", obj);
                    cmd.ExecuteNonQuery();
                    LoadRole(curRole);
                }catch(Exception) { }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
