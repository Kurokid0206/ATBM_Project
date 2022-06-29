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
using qlCSYT.UserSpace;
namespace qlCSYT
{
    public partial class frm_NhanVien_main : Form
    {
        public frm_NhanVien_main()
        {
            InitializeComponent();
        }
        private void LoadNV()
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            Console.WriteLine(conn);
            try
            {
                conn.Open();
                User User = new User();
                User.getRoles();
                //xử lý role ở đây
                //danh sách role ở dạng list: User.Roles
                //xem là role nào thì show role đó ra 
            }
            catch (Exception err)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo!");
                return;
            }
        }

        private void m_viewNV_Click(object sender, EventArgs e)
        {
            frm_viewNV frm_viewNV = new frm_viewNV();
            frm_viewNV.Show();
            this.Hide();
            frm_viewNV.Closed += (s, args) => this.Show(); //when other is closed, reopend this
        }
        private void m_modifyNV_Click(object sender, EventArgs e)
        {
            frm_modifyNV frm_modifyNV = new frm_modifyNV();
            frm_modifyNV.Show();
            this.Hide();
            frm_modifyNV.Closed += (s, args) => this.Show(); //when other is closed, reopend this
        }
    }
}
