using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DesktopBruteForcing
{
    static class Program
    {
        /// <summary>
        /// Main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            catch (Exception lObjExcepcion)
            {
                //Form1.Registro(lObjExcepcion.ToString());
            }
        }
    }
}
