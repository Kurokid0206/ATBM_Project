using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms;
using System.Data.Common;
using Oracle.DataAccess.Client;
using qlCSYT.SqlConn;

namespace qlCSYT
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void fMain_Load(object sender, EventArgs e)
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
            gv_main.DataSource = dt;
            //Delete button
            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "DELETE";
            deleteButton.Text = "x";
            deleteButton.UseColumnTextForButtonValue = true;
            this.gv_main.Columns.Add(deleteButton);
            // Add a CellClick handler to handle clicks in the button column.
            gv_main.CellClick += new DataGridViewCellEventHandler(DataGridViewUser_DeleteCellClick);

            //Show Priviledge Button
            var showPriviledgeButton = new DataGridViewButtonColumn();
            showPriviledgeButton.Name = "dataGridViewShowPriviledgeButton";
            showPriviledgeButton.HeaderText = "PRIVILEDGE";
            showPriviledgeButton.Text = "SHOW";
            showPriviledgeButton.UseColumnTextForButtonValue = true;
            this.gv_main.Columns.Add(showPriviledgeButton);
            // Add a CellClick handler to handle clicks in the button column.
            gv_main.CellClick += new DataGridViewCellEventHandler(DataGridViewUser_ShowPriviledgeCellClick);




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
        }
        private void DropUser(OracleConnection conn, string username)
        {

            OracleCommand cmd = new OracleCommand("dropUser", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@pi_username", username);

            cmd.ExecuteNonQuery();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLogin fLogin = new fLogin();
            fLogin.Show();
        }

        private void menustripUser_Click(object sender, EventArgs e)
        {
            this.gv_main.Columns.Clear();
            this.Hide();
            fMain fMain = new fMain();
            fMain.Show();
        }

        private void menustripRole_Click(object sender, EventArgs e)
        {
            this.gv_main.Columns.Clear();
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
            gv_main.DataSource = dt;
            //Delete button
            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "DELETE";
            deleteButton.Text = "x";
            deleteButton.UseColumnTextForButtonValue = true;
            this.gv_main.Columns.Add(deleteButton);
            // Add a CellClick handler to handle clicks in the button column.
            gv_main.CellClick += new DataGridViewCellEventHandler(DataGridViewRole_DeleteCellClick);

            //Show Priviledge Button
            var showPriviledgeButton = new DataGridViewButtonColumn();
            showPriviledgeButton.Name = "dataGridViewShowPriviledgeButton";
            showPriviledgeButton.HeaderText = "PRIVILEDGE";
            showPriviledgeButton.Text = "SHOW";
            showPriviledgeButton.UseColumnTextForButtonValue = true;
            this.gv_main.Columns.Add(showPriviledgeButton);
            // Add a CellClick handler to handle clicks in the button column.
            gv_main.CellClick += new DataGridViewCellEventHandler(DataGridViewUser_ShowPriviledgeCellClick);

        }
        void DataGridViewRole_DeleteCellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void DataGridViewRole_ShowPriviledgeCellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == gv_main.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            if (e.ColumnIndex == gv_main.Columns["dataGridViewShowPriviledgeButton"].Index)
            {
                string Rolename = gv_main.Rows[e.RowIndex].Cells[0].Value.ToString();
                OracleConnection conn = DBUtils.GetDBConnection();
                frm_ViewRole frm = new frm_ViewRole();
                frm.LoadRole(Rolename);
                //frm.MdiParent = this;
                this.Hide(); // hide when another is opened
                frm.Show(); //show next frm
                frm.Closed += (s, args) => this.Show(); //when other is closed, reopend this

            }
        }
    }
}
