using PRESENTATION.Views.Forms; 
using PRESENTATION.Views.Forms.Hotel;
using PRESENTATION.Views.Forms.Login; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTATION
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
            Application.Run(new Desktop());
            //Application.Run(new Login());
        }
    }
}
