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

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            f.Show();
            this.Close();
        }
    }
}
