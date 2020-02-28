using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalLibrary
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Open StartForm if it's the first time that program is run
            if (File.Exists(Configuration.pathtxt))
            {
                Application.Run(new MainForm());
            }
            else
            {
                Application.Run(new StartForm());
            }
        }
    }
}
