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
    public partial class frm_addEmp : Form
    {
        public frm_addEmp()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
