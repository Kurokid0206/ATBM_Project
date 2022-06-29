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
    public partial class frm_viewBN : Form
    {
        public frm_viewBN()
        {
            InitializeComponent();
            LoadSelfViewBN();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn hủy thao tác?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK) this.Close();
        }

        public void LoadSelfViewBN()
        {
            this.gv_viewSelf.Columns.Clear();
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("Select * from CSYT_ADMIN.VIEW_BENHNHAN_SELFVIEW", conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gv_viewSelf.DataSource = dt;
                gv_viewSelf.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                gv_viewSelf.AutoResizeColumns();
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

        private void lb_csytID_Click(object sender, EventArgs e)
        {

        }

        private void gv_viewSelf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void m_modifyBN_Click(object sender, EventArgs e)
        {
            frm_modifyBN frm_modifyBN = new frm_modifyBN();
            this.Hide(); // hide when another is opened
            frm_modifyBN.Show(); //show next frm
            frm_viewBN frm_viewBN = new frm_viewBN();
            frm_modifyBN.Closed += (s, args) => LoadSelfViewBN();
            frm_modifyBN.Closed += (s, args) => this.Show(); //when other is closed, reopend this
        }
    }
}
