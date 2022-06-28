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
    public partial class frm_YsBs_viewHSBA : Form
    {
        public frm_YsBs_viewHSBA()
        {
            InitializeComponent();
            LoadHSBA();
        }
        //private void frm_YsBs_viewHSBA_Load(object sender, EventArgs e)
        //{
        //LoadHSBA();
        //}
        private void LoadHSBA()
        {
            this.gv_HSBA.Columns.Clear();
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("Select * from CSYT_ADMIN.VIEW_BACSI_HSBA", conn);
                cmd.CommandType = System.Data.CommandType.Text;
                //cmd.Parameters.Add("@user_name", "ADMIN");
                //cmd.Parameters.Add("vCHASSIS_RESULT", OracleDbType.RefCursor, ParameterDirection.InputOutput);
                //OracleCommand cmd = new OracleCommand("CSYT_ADMIN.BACSI_SELECT_HSBA", conn);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@MaHSVA", MaHSBA);
                //cmd.Parameters.Add("vCHASSIS_RESULT", OracleDbType.RefCursor, ParameterDirection.InputOutput);
                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gv_HSBA.DataSource = dt;
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
            finally
            {

                conn.Close();
            }

            //Show Service Button
            var showServiceButton = new DataGridViewButtonColumn();
            showServiceButton.Name = "dataGridViewShowServiceButton";
            showServiceButton.HeaderText = "SERVICE";
            showServiceButton.Text = "SHOW";
            showServiceButton.UseColumnTextForButtonValue = true;
            this.gv_HSBA.Columns.Add(showServiceButton);
            // Add a CellClick handler to handle clicks in the button column.
            gv_HSBA.CellClick -= DataGridViewRole_ShowServiceCellClick;
            gv_HSBA.CellClick -= DataGridViewRole_ShowServiceCellClick;
            gv_HSBA.CellClick += DataGridViewRole_ShowServiceCellClick;


        }
        void DataGridViewRole_ShowServiceCellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == gv_HSBA.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            if (e.ColumnIndex == gv_HSBA.Columns["dataGridViewShowServiceButton"].Index)
            {
                string MaHSBA = gv_HSBA.Rows[e.RowIndex].Cells[1].Value.ToString();
                Console.WriteLine("HSBA:"+MaHSBA);
                OracleConnection conn = DBUtils.GetDBConnection();
                frm_YsBs_viewHSBA_DV frm = new frm_YsBs_viewHSBA_DV();
                frm.LoadHSBA_DV(MaHSBA);
                //frm.MdiParent = this;
                this.Hide(); // hide when another is opened
                frm.Show(); //show next frm
                frm.Closed += (s, args) => this.Show(); //when other is closed, reopend this

            }

        }
    }
}
