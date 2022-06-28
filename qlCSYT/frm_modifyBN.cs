using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using qlCSYT.SqlConn;

namespace qlCSYT
{
    public partial class frm_modifyBN : Form
    {
        public frm_modifyBN()
        {
            InitializeComponent();
        }


        private void frm_modifyBN_Load(object sender, EventArgs e)
        {

        }

        private void bt_TenBN_Click(object sender, EventArgs e)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd1 = new OracleCommand("CSYT_ADMIN.BENHNHAN_UPDATE_TENBN", conn);
                cmd1.CommandType = System.Data.CommandType.StoredProcedure;
                cmd1.Parameters.Add("@input", tb_TenBN.Text);
                cmd1.ExecuteNonQuery();
                //gv_viewPatient.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
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

        private void bt_CMND_Click(object sender, EventArgs e)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd1 = new OracleCommand("CSYT_ADMIN.BENHNHAN_UPDATE_CMND", conn);
                cmd1.CommandType = System.Data.CommandType.StoredProcedure;
                cmd1.Parameters.Add("@input", tb_CMND.Text);//here
                cmd1.ExecuteNonQuery();
                //gv_viewPatient.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
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

        private void bt_ngaysinh_Click(object sender, EventArgs e)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd1 = new OracleCommand("CSYT_ADMIN.BENHNHAN_UPDATE_NGAYSINH", conn);
                cmd1.CommandType = System.Data.CommandType.StoredProcedure;

                cmd1.Parameters.Add("@input", tb_ngaysinh.Value.Date);//here
                cmd1.ExecuteNonQuery();
                //gv_viewPatient.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
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

        private void bt_SoNha_Click(object sender, EventArgs e)
        {

        }
    }
}
