using qlCSYT;
using System;
using System.Windows.Forms;


namespace CsOracleTutorial
{

    class QueryDataExample
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fLogin());
        }
    }
}