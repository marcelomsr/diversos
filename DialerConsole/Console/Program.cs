using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Console
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(MyHandler);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Principal MainWindow = new Principal();

            AutoWaitCursor.Cursor = Cursors.WaitCursor;
            AutoWaitCursor.Delay = new TimeSpan(0, 0, 0, 0, 25);
            // Set the window handle to the handle of the main form in your application
            AutoWaitCursor.MainWindowHandle = MainWindow.Handle;
            AutoWaitCursor.Start();

            Application.Run(MainWindow);
        }

        static void MyHandler(object sender, UnhandledExceptionEventArgs args)
        {
            Exception e = (Exception)args.ExceptionObject;

            StringBuilder mensagem = new StringBuilder();

            mensagem.Append(e.Message + "\n\n");
            mensagem.Append("StackTrace:\n" + e.StackTrace.ToString());

            MessageBox.Show(mensagem.ToString(), "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
