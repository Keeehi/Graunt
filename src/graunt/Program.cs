using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graunt
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
            GrauntSettings.Initialize();
            Language.Initialize();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            mainWindow.Hide();
            Application.Run();
            GrauntSettings.Save();
        }
    }
}
