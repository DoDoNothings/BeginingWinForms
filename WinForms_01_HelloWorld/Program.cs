using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace WinForms_01_HelloWorld
{
    static class Program
    {
        public static NLog.Logger Logger;
        private static void LoggerConfig()
        {
            Logger = NLog.LogManager.GetCurrentClassLogger();

        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LoggerConfig();
            Program.Logger.Info("Fictions");
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
