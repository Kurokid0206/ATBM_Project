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
    public partial class frm_viewSelf : Form
    {
        public frm_viewSelf()
        {
            InitializeComponent();
            LoadSelfView(LoadID());
        }
        private string LoadID()
        {
            string id = null;
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select user from dual";
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //int  userindex= reader.GetOrdinal("user");
                            //string id = reader.GetString(userindex);
                            id = reader.GetString(0);
                            Console.WriteLine(id);
                        }

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            Console.Read();
            
            if (id.Contains("NV")) return "NV";
            else if (id.Contains("BN")) return "BN";
            else return null;
        }
        private void LoadSelfView(string role)
        {
            if (role == "NV")
            {
                frm_viewNV f= new frm_viewNV();
                f.Show();            }
            else if (role == "BN")
            {
                frm_viewBN f = new frm_viewBN();
                f.Show();
            }
            else
            {
                fMain f = new fMain();
                f.Show();
            }
            
        }


    }
}
