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
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            OracleCommand cmd = new OracleCommand("ShowTableCol", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@tblname", "CSYT");
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
    }
}
