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
using System.Runtime.InteropServices;
using qlCSYT;

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

                //DataTable dt = new DataTable();
                ////Tải dữ liệu lên dataGridView
                //DataListUser.DataSource = dt;

                ////Tải dữ liệu lên listView
                //int i = 0;
                //foreach (DataRow dr in dt.Rows)
                //{
                //    DataListUser.Items.Add(dr["id"].ToString());
                //    DataListUser.Items[i].SubItems.Add(dr["ten"].ToString());
                //    i++;
                //}

                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        DataTable ListUser = new DataTable();
                        ListUser.Columns.Add("TenNguoiDung", typeof(string));
                        while (reader.Read())
                        {
                            ListUser.Rows.Add(reader.GetString(0));

                        }
                        //DataGridViewUser.DisplayMember = "Username";
                        //DataGridViewUser.ValueMember = "Username";
                        //DataRow temprow = DataGridViewUser.Rows.
                        DataGridViewUser.DataSource= ListUser;

                        //Delete button
                        var deleteButton = new DataGridViewButtonColumn();
                        deleteButton.Name = "dataGridViewDeleteButton";
                        deleteButton.HeaderText = "XoaNguoiDung";
                        deleteButton.Text = "Xoa";
                        deleteButton.UseColumnTextForButtonValue = true;
                        this.DataGridViewUser.Columns.Add(deleteButton);
                        // Add a CellClick handler to handle clicks in the button column.
                        DataGridViewUser.CellClick +=
                            new DataGridViewCellEventHandler(DataGridViewUser_DeleteCellClick);

                        //Data Taking Button
                        var dataButton= new DataGridViewButtonColumn();
                        dataButton.Name = "dataGridViewDataButton";
                        dataButton.HeaderText = "InNguoiDung";
                        dataButton.Text = "In";
                        dataButton.UseColumnTextForButtonValue = true;
                        this.DataGridViewUser.Columns.Add(dataButton);
                        DataGridViewUser.CellClick +=
                            new DataGridViewCellEventHandler(DataGridViewUser_DataCellClick);

                    }
                    else
                    {
                        Console.WriteLine("failed");
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                conn.Close();
                conn.Dispose();

            }
            Console.Read();

        }
        void DataGridViewUser_DeleteCellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == DataGridViewUser.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == DataGridViewUser.Columns["dataGridViewDeleteButton"].Index)
            {

                OracleConnection conn = DBUtils.GetDBConnection();
                string username = DataGridViewUser.Rows[e.RowIndex].Cells[0].Value.ToString();

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

        void DataGridViewUser_DataCellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == DataGridViewUser.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == DataGridViewUser.Columns["dataGridViewDataButton"].Index)
            {
                //Put some logic here, for example to remove row from your binding list.
                //yourBindingList.RemoveAt(e.RowIndex);
                //DataRow row = DataGridViewUser.Select();
                //Console.Write("Hello");
                //Console.Write(DataGridViewUser.Rows[e.RowIndex].ToString());

                string username = DataGridViewUser.Rows[e.RowIndex].Cells[0].Value.ToString();
                Console.WriteLine(username);


                //TextBox box1= new System.Windows.Forms.TextBox();
                //FakeConsole.AppendText(DataGridViewUser.Rows[e.RowIndex].Cells[0].Value.ToString());
                // Or
                // var data = (Product)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                // do something 
            }
            
        }
        
        private void DataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DropUser(OracleConnection conn, string username)
        {

            OracleCommand cmd = new OracleCommand("dropUser", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@pi_username", username);

            cmd.ExecuteNonQuery();
            
        }
    }
}
