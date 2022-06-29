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
    public partial class frm_BenhNhan_main : Form
    {
        public frm_BenhNhan_main()
        {
            InitializeComponent();
        }

        private void m_viewBN_Click(object sender, EventArgs e)
        {
            frm_viewBN frm = new frm_viewBN();
            //frm.MdiParent = this;
            this.Hide(); // hide when another is opened
            frm.Show(); //show next frm
            frm.Closed += (s, args) => this.Show(); //when other is closed, reopend this

        }

        private void m_modifyBN_Click(object sender, EventArgs e)
        { 

            frm_modifyBN frm1 = new frm_modifyBN();
            this.Hide(); // hide when another is opened
            frm1.Show(); //show next frm
            frm1.Closed += (s, args) => this.Show(); //when other is closed, reopend this
            
        }

    }
}
