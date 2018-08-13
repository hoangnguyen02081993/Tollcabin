using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using System.Windows.Forms;
using Tollcabin.My;

namespace Tollcabin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.SetCompatibleTextRenderingDefault(false);
            }
            finally
            {
            }
            var logRepository = log4net.LogManager.GetRepository(System.Reflection.Assembly.GetEntryAssembly());
            log4net.Config.XmlConfigurator.Configure(logRepository, new System.IO.FileInfo(Directory.GetCurrentDirectory() + "/log4net.config"));

            MyProject.Application.Run(new string[1]);
        }
    }
}
