﻿using Infrastructure.cs.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxisCaptureManager
{
    static class Program
    {
        private static Mutex globalMutex = new Mutex(false, "Global\\{{f211984f-2b84-4f51-b37e-02f6e14d61d8}}");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                if(!globalMutex.WaitOne(3000, false))
                {
                    MessageBox.Show("Đã có chương trình đang chạy. Không thể mở thêm", "Axis manager - Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var logRepository = log4net.LogManager.GetRepository(System.Reflection.Assembly.GetEntryAssembly());
                log4net.Config.XmlConfigurator.Configure(logRepository, new System.IO.FileInfo(Directory.GetCurrentDirectory() + "/log4net.config"));
                LogHelper.GetLogger().Info("Khởi động chương trình");

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new AxisManager());
            }
            catch(Exception ex)
            {
                //todo log
            }
            finally
            {
                // try to release mutex
                try
                {
                    globalMutex.ReleaseMutex();
                }
                catch { }
            }
        }
    }
}
