using Oracle.DataAccess.Client;
using qlCSYT.SqlConn;
using System;
using System.Windows.Forms;


namespace qlCSYT
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            OracleConnection conn = DBUtils.GetDBConnection(username, password);

            if (username == null || username.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập Username!", "Thông báo!");
                return;
            }
            if (password == null || password.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập Password!", "Thông báo!");
                return;
            }
            try
            {
                conn.Open();
                //Chuyen form
                this.Hide();
                frm_NghienCuu fMain = new frm_NghienCuu();
                fMain.Show();
            }
            catch (Exception err)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo!");
                return;
            }
        }
    }
}
