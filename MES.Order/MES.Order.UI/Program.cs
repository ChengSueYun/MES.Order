using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using MES.Order.UI.New;

namespace MES.Order.UI
{
    internal static class Program
    {
        private static Form mMainForm;

        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);

        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        /// <summary>
        ///     應用程式的主要進入點。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            RegisterGlobalErrorHandler();

            Application.EnableVisualStyles();
            Application.DoEvents();

            //取得執行中的處理序
            var instance = RunningInstance();
            if (instance == null)
            {
                Application.EnableVisualStyles();
                Application.DoEvents();
                AntWorkManager.GetAsyncData();
                mMainForm = new FluentMainForm();

                if (mMainForm.IsDisposed == false) Application.Run(mMainForm);
            }
            //HandleRunningInstance(instance);
        }


        private static void RegisterGlobalErrorHandler()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // Add handler to handle the exception raised by main threads
            Application.ThreadException += Application_ThreadException;

            // Add handler to handle the exception raised by additional threads
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        public static Process RunningInstance()
        {
            var current = Process.GetCurrentProcess(); // 取得目前作用中的處理序
            var processes = Process.GetProcessesByName(current.ProcessName); // 取得指定的處理緒名稱的所有處理序

            //尋找相同名稱的處理序
            foreach (var process in processes)
                if (process.Id != current.Id)
                    if (Assembly.GetExecutingAssembly().Location.Replace("/", "\\") == current.MainModule.FileName)
                        return process;

            return null;
        }

        public static void HandleRunningInstance(Process instance)
        {
            //設定視窗大小
            //ShowWindowAsync(instance.MainWindowHandle, WS_SHOWNORMAL);
            //將執行個體設為前景
            SetForegroundWindow(instance.MainWindowHandle);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var exception = (Exception)e.ExceptionObject;
            Error(exception);
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Error(e.Exception);
        }

        private static void Error(Exception ex)
        {
            MessageBox.Show(@"發生異常，請聯繫系統管理員" + Environment.NewLine + "(" + ex + ")", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}