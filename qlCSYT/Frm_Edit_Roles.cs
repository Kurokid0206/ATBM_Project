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
    public partial class Frm_Edit_Roles : Form
    {
        public Frm_Edit_Roles()
        {
            InitializeComponent();
        }

        private void Frm_Edit_Roles_Load(object sender, EventArgs e)
        {

        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            frm_ViewUser frm = new frm_ViewUser();
            frm.LoadUser("C##CSYT_ADMIN");
            //frm.MdiParent = this;
            this.Hide(); // hide when another is opened
            frm.Show(); //show next frm
            frm.Closed += (s, args) => this.Show(); //when other is closed, reopend this
        }
    }
}
