using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data.Common;
using Oracle.DataAccess.Client;
using qlCSYT.SqlConn;

namespace qlCSYT
{
    public partial class frm_addEmp : Form
    {
        public frm_addEmp()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn hủy thao tác?", "Thông báo", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK) this.Close();
        }

        private void frm_addEmp_Load(object sender, EventArgs e)
        {
            cb_gender.DisplayMember = "Phai";
            cb_gender.ValueMember = "Phai";

            var gender = new[] {
            new { Phai = "Nam"},
            new { Phai = "Nữ"}
            };

            cb_gender.DataSource = gender;

            cb_role.DisplayMember = "VaiTro";
            cb_role.ValueMember = "VaiTro";

            var role = new[] {
            new { VaiTro = "Thanh tra"},
            new { VaiTro = "Cơ sở y tế"},
            new { VaiTro = "Bác sĩ"},
            new { VaiTro = "Nghiên cứu"}
            };

            cb_role.DataSource = role;

            qryGetMedFac();
        }
        private void qryGetMedFac()
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                string sql = "Select * from CSYT";

                // Tạo một đối tượng Command.
                OracleCommand cmd = new OracleCommand(sql, conn);

                using (DbDataReader reader = cmd.ExecuteReader())
                {

                    if (reader.HasRows)
                    {

                        DataTable tbl = new DataTable();
                        tbl.Columns.Add("MaCSYT", typeof(string));
                        tbl.Columns.Add("TenCSYT", typeof(string));
                        while (reader.Read())
                        {
                            string medFacID = reader.GetString(1);
                            tbl.Rows.Add(reader.GetString(0), reader.GetString(1));
                        }
                        cb_MedFac.DataSource = tbl;
                        cb_MedFac.DisplayMember = "TenCSYT";
                        cb_MedFac.ValueMember = "MaCSYT";
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
        }

        private void btn_addPatient_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            DateTime ntns = time_Birth.Value;
            string gender = cb_gender.SelectedValue.ToString();
            string telephone = txt_telephone.Text;
            string origin = txt_origin.Text;
            string medFac = cb_MedFac.SelectedValue.ToString();
            string role = cb_role.SelectedValue.ToString();
            string specialist = txt_specialist.Text;

            OracleConnection conn = DBUtils.GetDBConnection();
            
            try
            {
                conn.Open();

                CreateEmp(conn,username,password);
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
                MessageBox.Show("Thêm nhân viên thành công!","Thông báo");
                this.Close();
            }
            Console.Read();
        }
        private void CreateEmp(OracleConnection conn, string username,string password)
        {
            
            OracleCommand cmd = new OracleCommand("CreateUser", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@pi_username", username);
            cmd.Parameters.Add("@pi_password", password);
            cmd.ExecuteNonQuery();            
        }

        private void txt_idNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb_csytNo_Click(object sender, EventArgs e)
        {

        }

        private void cb_role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb_password_Click(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_MedFac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
