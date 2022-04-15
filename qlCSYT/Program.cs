using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qlCSYT.SqlConn;
using System.Data;
using System.Data.Common;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

using System.Windows.Forms;
using qlCSYT;


namespace CsOracleTutorial
{

    class QueryDataExample
    {
        [STAThread]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_addPatient());
        }
    }

}