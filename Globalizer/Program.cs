using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Globalizer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainWindow = new Globalizer.Forms.MainWindow();
            Application.Run(MainWindow);
        }

        internal static Globalizer.Forms.MainWindow MainWindow;
    }
}
