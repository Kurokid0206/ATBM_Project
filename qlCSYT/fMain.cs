using Oracle.DataAccess.Client;
using qlCSYT.SqlConn;
using System;
using System.Data;
using System.Windows.Forms;

namespace qlCSYT
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }



        private void fMain_Load(object sender, EventArgs e)
        {
            LoadUsers();

        }

        void DataGridViewUser_ShowPriviledgeCellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == gv_main.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            if (e.ColumnIndex == gv_main.Columns["dataGridViewShowPriviledgeButton"].Index)
            {
                string username = gv_main.Rows[e.RowIndex].Cells[0].Value.ToString();
                OracleConnection conn = DBUtils.GetDBConnection();
                frm_ViewUser frm = new frm_ViewUser();
                frm.LoadUser(username);
                //frm.MdiParent = this;
                this.Hide(); // hide when another is opened
                frm.Show(); //show next frm
                frm.Closed += (s, args) => this.Show(); //when other is closed, reopend this

            }

        }
        void DataGridViewRole_ShowPriviledgeCellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == gv_main.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            if (e.ColumnIndex == gv_main.Columns["dataGridViewShowPriviledgeButton"].Index)
            {
                string roleName = gv_main.Rows[e.RowIndex].Cells[0].Value.ToString();
                OracleConnection conn = DBUtils.GetDBConnection();
                frm_ViewRole frm = new frm_ViewRole();
                frm.LoadRole(roleName);
                //frm.MdiParent = this;
                this.Hide(); // hide when another is opened
                frm.Show(); //show next frm
                frm.Closed += (s, args) => this.Show(); //when other is closed, reopend this

            }

        }
        void DataGridViewUser_DeleteCellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == gv_main.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            if (e.ColumnIndex == gv_main.Columns["dataGridViewDeleteButton"].Index)
            {

                OracleConnection conn = DBUtils.GetDBConnection();
                string username = gv_main.Rows[e.RowIndex].Cells[0].Value.ToString();
                try
                {
                    conn.Open();

                    DropUser(conn, username);
                }
                catch (Exception err)
                {
                    Console.WriteLine("Error: " + err);
                    Console.WriteLine(err.StackTrace);
                }
                finally
                {
                    Console.WriteLine("Completed!");
                    conn.Close();
                    conn.Dispose();
                }
                Console.Read();
            }
            LoadUsers();
        }
        void DataGridViewRole_DeleteCellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == gv_main.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            if (e.ColumnIndex == gv_main.Columns["dataGridViewDeleteButton"].Index)
            {

                OracleConnection conn = DBUtils.GetDBConnection();
                string roleName = gv_main.Rows[e.RowIndex].Cells[0].Value.ToString();
                try
                {
                    conn.Open();

                    DropRole(conn, roleName);
                }
                catch (Exception err)
                {
                    Console.WriteLine("Error: " + err);
                    Console.WriteLine(err.StackTrace);
                }
                finally
                {
                    Console.WriteLine("Completed!");
                    conn.Close();
                    conn.Dispose();
                }
                Console.Read();
            }
            LoadRoles();
        }
        private void DropUser(OracleConnection conn, string username)
        {

            OracleCommand cmd = new OracleCommand("dropUser", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@pi_username", username);

            cmd.ExecuteNonQuery();

        }
        private void DropRole(OracleConnection conn, string roleName)
        {

            OracleCommand cmd = new OracleCommand("dropRole", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@pi_roleName", roleName);

            cmd.ExecuteNonQuery();

        }




        private void m_showUserList_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void m_logout_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            f.Show();
            this.Close();
        }

        private void LoadUsers()
        {
            this.gv_main.Columns.Clear();
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("ShowAllUser", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@user_name", "ADMIN");
                cmd.Parameters.Add("vCHASSIS_RESULT", OracleDbType.RefCursor, ParameterDirection.InputOutput);
                cmd.ExecuteNonQuery();

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();


                da.Fill(dt);
                gv_main.DataSource = dt;
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
            finally
            {

                conn.Close();
            }
            //Delete button
            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "DELETE";
            deleteButton.Text = "x";
            deleteButton.UseColumnTextForButtonValue = true;
            this.gv_main.Columns.Add(deleteButton);
            // Add a CellClick handler to handle clicks in the button column.
            gv_main.CellClick -= DataGridViewUser_DeleteCellClick;
            gv_main.CellClick -= DataGridViewRole_DeleteCellClick;
            gv_main.CellClick += DataGridViewUser_DeleteCellClick;


            //Show Priviledge Button
            var showPriviledgeButton = new DataGridViewButtonColumn();
            showPriviledgeButton.Name = "dataGridViewShowPriviledgeButton";
            showPriviledgeButton.HeaderText = "PRIVILEDGE";
            showPriviledgeButton.Text = "SHOW";
            showPriviledgeButton.UseColumnTextForButtonValue = true;
            this.gv_main.Columns.Add(showPriviledgeButton);
            // Add a CellClick handler to handle clicks in the button column.
            gv_main.CellClick -= DataGridViewUser_ShowPriviledgeCellClick;
            gv_main.CellClick -= DataGridViewRole_ShowPriviledgeCellClick;
            gv_main.CellClick += DataGridViewUser_ShowPriviledgeCellClick;


        }
        private void LoadRoles()
        {
            this.gv_main.Columns.Clear();
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                OracleCommand cmd = new OracleCommand("ShowAllRole", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@user_name", "ADMIN");
                cmd.Parameters.Add("vCHASSIS_RESULT", OracleDbType.RefCursor, ParameterDirection.InputOutput);
                cmd.ExecuteNonQuery();

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();


                da.Fill(dt);
                gv_main.DataSource = dt;
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
            finally
            {

                conn.Close();
            }
            //Delete button
            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "DELETE";
            deleteButton.Text = "x";
            deleteButton.UseColumnTextForButtonValue = true;
            this.gv_main.Columns.Add(deleteButton);
            // Add a CellClick handler to handle clicks in the button column.
            gv_main.CellClick -= DataGridViewUser_DeleteCellClick;
            gv_main.CellClick -= DataGridViewRole_DeleteCellClick;
            gv_main.CellClick += DataGridViewRole_DeleteCellClick;
            //Show Priviledge Button
            var showPriviledgeButton = new DataGridViewButtonColumn();
            showPriviledgeButton.Name = "dataGridViewShowPriviledgeButton";
            showPriviledgeButton.HeaderText = "PRIVILEDGE";
            showPriviledgeButton.Text = "SHOW";
            showPriviledgeButton.UseColumnTextForButtonValue = true;
            this.gv_main.Columns.Add(showPriviledgeButton);
            // Add a CellClick handler to handle clicks in the button column.
            gv_main.CellClick -= DataGridViewRole_ShowPriviledgeCellClick;
            gv_main.CellClick += DataGridViewRole_ShowPriviledgeCellClick;
            gv_main.CellClick -= DataGridViewUser_ShowPriviledgeCellClick;


        }

        private void m_showRoleList_Click(object sender, EventArgs e)
        {
            LoadRoles();
        }

        private void m_addEmp_Click(object sender, EventArgs e)
        {
            frm_addEmp frm = new frm_addEmp();
            this.Hide();
            frm.Closed += (s, args) => this.Show();
            frm.Show();
        }

        private void m_addPatient_Click(object sender, EventArgs e)
        {
            frm_addPatient frm = new frm_addPatient();
            this.Hide();
            frm.Closed += (s, args) => this.Show();

            frm.Show();
        }

        private void gv_main_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void m_user_Click(object sender, EventArgs e)
        {

        }

        private void m_main_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void m_addRole_Click(object sender, EventArgs e)
        {
            frm_addRole frm = new frm_addRole();
            this.Hide();
            frm.Closed += (s, args) => this.Show();
            frm.Show();
        }

        private void m_grantPriv_Click(object sender, EventArgs e)
        {
            frm_priviledges frm = new frm_priviledges();
            this.Hide();
            frm.Closed += (s, args) => this.Show();
            frm.Show();
        }
    }
}
