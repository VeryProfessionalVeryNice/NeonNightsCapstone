using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectNeon
{
    static class Program
    {
        static Form MainForm;
        static Form SplashScreen;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show splash
            SplashScreen = new SplashScreen();
            var splashThread = new Thread(
                () => Application.Run(SplashScreen));
            splashThread.SetApartmentState(ApartmentState.STA);
            splashThread.Start();

            // Create and show the main form
            MainForm = new Form1();
            MainForm.Load += MainForm_LoadCompleted;

            Application.Run(MainForm);
        }

        private static void MainForm_LoadCompleted(object sender, EventArgs e)
        {
            if(SplashScreen != null && !SplashScreen.Disposing && !SplashScreen.IsDisposed)
            {
                SplashScreen.Invoke(new Action(() => SplashScreen.Close()));
            }

            MainForm.TopMost = true;
            MainForm.Activate();
            MainForm.TopMost = false;
        }
    }
}
