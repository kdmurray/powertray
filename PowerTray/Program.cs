using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PowerTray
{
    static class Driver
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
#if DEBUG
            System.Diagnostics.Debug.Print("Begin PowerTray execution sequence...");
#endif
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm form = new MainForm();
            form.WindowState = FormWindowState.Minimized;
            form.ShowInTaskbar = false;
            form.myMode = FormModes.FirstLoad;
            Application.Run(form);
        }
    }
}