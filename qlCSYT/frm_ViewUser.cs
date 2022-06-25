using Oracle.DataAccess.Client;
using qlCSYT.SqlConn;
using System;
using System.Data;
using System.Windows.Forms;


namespace qlCSYT
{
    public partial class frm_ViewUser : Form
    {
        private string currUser = "";
        public frm_ViewUser()
        {
            InitializeComponent();
        }

        private void frm_ViewUser_Load(object sender, EventArgs e)
        {

        }
        public void LoadUser(string username)
        {
            gv_User.Columns.Clear();
            gv_update_col_priv.Columns.Clear();
            currUser = username;
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
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
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
            finally
            {

                conn.Close();
            }
            //Revoke Button
            var revokeButton = new DataGridViewButtonColumn();
            revokeButton.Name = "dataGridViewUserRevokeButton";
            revokeButton.HeaderText = "REVOKE";
            revokeButton.Text = "x";
            revokeButton.UseColumnTextForButtonValue = true;
            this.gv_User.Columns.Add(revokeButton);
            gv_User.CellClick -= DataGridViewUser_RevokeCellClick;
            gv_User.CellClick += DataGridViewUser_RevokeCellClick;


            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("SHOWUPDATEPRIVILEGESFORUSER", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@user_name", username);
                cmd.Parameters.Add("vCHASSIS_RESULT", OracleDbType.RefCursor, ParameterDirection.InputOutput);
                cmd.ExecuteNonQuery();

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gv_update_col_priv.DataSource = dt;


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
            this.gv_update_col_priv.Columns.Add(revokeButton2);
            gv_update_col_priv.CellClick -= DataGridViewUser_RevokeUpdateCellClick;
            gv_update_col_priv.CellClick += DataGridViewUser_RevokeUpdateCellClick;
        }
        void DataGridViewUser_RevokeCellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == gv_User.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            if (e.ColumnIndex == gv_User.Columns["dataGridViewUserRevokeButton"].Index)
            {
                string username = gv_User.Rows[e.RowIndex].Cells[0].Value.ToString();
                string priviledge = gv_User.Rows[e.RowIndex].Cells[2].Value.ToString();
                string obj = gv_User.Rows[e.RowIndex].Cells[1].Value.ToString();
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
                LoadUser(currUser);
            }
        }

        void DataGridViewUser_RevokeUpdateCellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == gv_update_col_priv.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            if (e.ColumnIndex == gv_update_col_priv.Columns["dataGridViewUserRevokeButton"].Index)
            {
                string username = gv_update_col_priv.Rows[e.RowIndex].Cells[0].Value.ToString();
                string priviledge = gv_update_col_priv.Rows[e.RowIndex].Cells[2].Value.ToString();
                string obj = gv_update_col_priv.Rows[e.RowIndex].Cells[1].Value.ToString();

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
                LoadUser(currUser);
            }
        }

    }
}
