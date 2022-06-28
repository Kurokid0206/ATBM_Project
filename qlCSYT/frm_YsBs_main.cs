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
    public partial class frm_YsBs_main : Form
    {
        public frm_YsBs_main()
        {
            InitializeComponent();
        }   
        private void frm_YsBs_main_Load(object sender, EventArgs e)
        {

        }
        private void m_viewHSBA_Click(object sender, EventArgs e)
        {
            //template for view HSBA thing (Y si, Bac Si)
            frm_YsBs_viewHSBA f = new frm_YsBs_viewHSBA();
            f.Show();
            this.Hide();
            f.Closed += (s, args) => this.Show(); //when other is closed, reopend this
        }

        private void m_viewPatient_Click(object sender, EventArgs e)
        {
            //template for view Patient thing (Y si, Bac Si)
            frm_YsBs_viewPatient f = new frm_YsBs_viewPatient();
            f.Show();
            this.Hide();
            f.Closed += (s, args) => this.Show(); //when other is closed, reopend this
        }
    }
}
        

        

