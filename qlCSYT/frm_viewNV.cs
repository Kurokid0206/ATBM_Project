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
    public partial class frm_viewNV : Form
    {
        public frm_viewNV()
        {
            InitializeComponent();
            LoadSelfView();
        }
        private void LoadSelfView()
        {
            this.gv_viewSelf.Columns.Clear();
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("Select * from CSYT_ADMIN.VIEW_NHANVIEN_SELFVIEW", conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gv_viewSelf.DataSource = dt;
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
            finally
            {

                conn.Close();
            }
        }

        private void m_modifyNV_Click(object sender, EventArgs e)
        {
            frm_modifyNV frm_modifyNV = new frm_modifyNV();
            frm_modifyNV.Show();
            this.Hide();
            frm_viewNV frm_viewNV = new frm_viewNV();
            frm_modifyNV.Closed += (s, args) => frm_viewNV.Show(); //when other is closed, reopend this
        }
    }
}
