using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlCSYT
{
    public partial class frm_ViewUser : Form
    {
        public frm_ViewUser()
        {
            InitializeComponent();
        }

        private void frm_ViewUser_Load(object sender, EventArgs e)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                string sql = "SELECT USERNAME FROM all_users where USERNAME like 'C##CSYT%'";
                // Tạo một đối tượng Command.
                OracleCommand cmd = new OracleCommand(sql, conn);
                using (DbDataReader reader = cmd.ExecuteReader())
                {

                    if (reader.HasRows)
                    {

                        DataTable listuser = new DataTable();
                        tbl.Columns.Add("MaCSYT", typeof(string));
                        tbl.Columns.Add("TenCSYT", typeof(string));
                        while (reader.Read())
                        {
                            string medFacID = reader.GetString(1);
                            tbl.Rows.Add(reader.GetString(0), reader.GetString(1));
                        }
                        cbMedFac.DataSource = tbl;
                        cbMedFac.DisplayMember = "TenCSYT";
                        cbMedFac.ValueMember = "MaCSYT";
                    }
                    else
                    {
                        Console.WriteLine("failed");
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



        
        private void DataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == DataGridViewUser.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == DataGridViewUser.Columns["TenNguoiDung"].Index)
            {
                //Put some logic here, for example to remove row from your binding list.
                //yourBindingList.RemoveAt(e.RowIndex);
                //DataRow row = DataGridViewUser.Select();
                Console.Write("Hello");
                Console.Write(DataGridViewUser.Rows[e.RowIndex].ToString());
                Console.WriteLine();
                //TextBox box1= new System.Windows.Forms.TextBox();
                FakeConsole.AppendText(DataGridViewUser.Rows[e.RowIndex].Cells[0].Value.ToString());
                // Or
                // var data = (Product)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                // do something 
            }
        }
       
    }
}
