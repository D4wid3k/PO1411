using ClassLibrary3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Dziekanat
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //initialize Data base 
            ClassLibrary3.GlobalConfig.InitializeConnections();

            Application.Run(new Wnioski());
        }
    }
}
