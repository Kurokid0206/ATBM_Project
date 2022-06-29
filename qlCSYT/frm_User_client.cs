using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlCSYT.UserSpace;
using Oracle.DataAccess.Client;
using qlCSYT.SqlConn;
namespace qlCSYT
{
    public partial class frm_User_client : Form
    {
        public frm_User_client()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void ThanhTra_strip_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_ThanhTra frm_ThanhTra = new frm_ThanhTra();
            frm_ThanhTra.Show();
            frm_ThanhTra.Closed += (s, args) => this.Show();
        }

        private void frm_User_client_Load(object sender, EventArgs e)
        {
            ThongTInCN_strip.Enabled = true;
            ThanhTra_strip.Enabled = false;
            BacSi_strip.Enabled = false;
            QLDL_strip.Enabled = false;
            NghienCuu_strip.Enabled = false;
            Admin_strip.Enabled = false;
            logout_strip.Enabled = true;

            if (User.Roles.Contains("CSYT_ROLE_QUANLIDULIEU"))
            {
                QLDL_strip.Enabled = true;
            }
            if (User.Roles.Contains("CSYT_ROLE_BACSI"))
            {
                BacSi_strip.Enabled = true;
            }
            if (User.Roles.Contains("CSYT_ROLE_THANHTRA"))
            {
                ThanhTra_strip.Enabled = true;
            }
            if (User.Roles.Contains("CSYT_ROLE_NGHIENCUU"))
            {
                NghienCuu_strip.Enabled = true;
            }
            //Chuyen form
            if (User.username == "ADMIN")
            {
                Admin_strip.Enabled = true;
                    
            }

        }

        private void BacSi_strip_Click(object sender, EventArgs e)
        {
            //template for view HSBA thing (Y si, Bac Si)
            frm_YsBs_viewHSBA f = new frm_YsBs_viewHSBA();
            f.Show();
            this.Hide();
            f.Closed += (s, args) => this.Show(); //when other is closed, reopend this
        }

        private void QLDL_strip_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_QLDL_main frm_QLDL_main = new frm_QLDL_main();
            frm_QLDL_main.Show();
            frm_QLDL_main.Closed += (s, args) => this.Show();
        }

        private void NghienCuu_strip_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_NghienCuu frm_NghienCuu = new frm_NghienCuu();
            frm_NghienCuu.Show();
            frm_NghienCuu.Closed += (s, args) => this.Show();
        }

        private void Admin_strip_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMain frm = new fMain();
            frm.Show();
            frm.Closed += (s, args) => this.Show();
        }

        private void ThongTInCN_strip_Click(object sender, EventArgs e)
        {
            User User = new User();
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            User.getRoles();
            if (User.Roles.Contains("CSYT_ROLE_NHANVIEN"))
            {
                this.Hide();
                frm_viewNV frm_viewNV = new frm_viewNV();
                frm_viewNV.Show();
                frm_viewNV.Closed += (s, args) => this.Show();
            }
            else if (User.Roles.Contains("CSYT_ROLE_BENHNHAN"))
            {
                this.Hide();
                frm_viewBN frm_viewBN = new frm_viewBN();
                frm_viewBN.Show();
                frm_viewBN.Closed += (s, args) => this.Show();
            }

        }
    }
}
