using BusinessObjects;
using GiftHommieWinforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiftHommieWinforms
{
    internal static class GlobalData
    {
        public static User AuthenticatedUser { get; set; }

        static GlobalData()
        {
            AuthenticatedUser = null;
        }
    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            //Application.Run(new frmCreateOrder());
        }
    }
}
