using System;
using AncibleSpark.Forms;
using System.Windows.Forms;

namespace AncibleSpark
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (MainWindow mainWindow = new MainWindow())
            {
                Application.Run(mainWindow);
            }
        }
    }
#endif
}
