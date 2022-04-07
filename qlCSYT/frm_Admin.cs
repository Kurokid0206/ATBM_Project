using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlCSYT;

namespace qlCSYT
{
    public partial class frm_Admin : Form
    {
        public frm_Admin()
        {
            InitializeComponent();
        }

        private void showPriviledge_Click(object sender, EventArgs e)
        {
            Frm_Priviledges frm = new Frm_Priviledges();
            //frm.MdiParent = this;
            this.Hide(); // hide when another is opened
            frm.Show(); //show next frm
            frm.Closed += (s, args) => this.Show();
        }
    }
}
