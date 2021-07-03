using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoFlash
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*
            ProgressBar pBar = new ProgressBar();
            pBar.Visible = true;
            pBar.Minimum = 1;
            pBar.Maximum = 100;
            pBar.Value = 1;
            pBar.Step = 1;
            5
            for (int x = 1; x <= 100; x++)
            {
                pBar.PerformStep();
            }*/
            
            Application.Run(new Crypto());
        }
    }
}
