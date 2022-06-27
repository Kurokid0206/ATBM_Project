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
    public partial class frm_ThanhTra : Form
    {
        public frm_ThanhTra()
        {
            InitializeComponent();
        }

        private void menu_logout_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            f.Show();
            this.Close();
        }

        private void menu_xemHSBA_Click(object sender, EventArgs e)
        {

        }

        private void menu_xemHSBA_DV_Click(object sender, EventArgs e)
        {

        }

        private void menu_xemBenhNhan_Click(object sender, EventArgs e)
        {

        }

        private void menu_xemCSYT_Click(object sender, EventArgs e)
        {

        }

        private void menu_xemNhanVien_Click(object sender, EventArgs e)
        {

        }
    }
}
