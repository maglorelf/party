namespace party.windows
{
    using System;
    using System.Threading;
    using System.Windows.Forms;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using party.windows.configuration.startup;
    using party.windows.forms;
    using Serilog;

    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new ThreadExceptionEventHandler(ThreadException);
            IHost host = ConfigureStartup.Startup();
            Log.Logger.Information("Application Starting");

            var mainForm = ActivatorUtilities.CreateInstance<AttendanceForm>(host.Services);
            Application.Run(mainForm);
            Log.Logger.Information("Application Ending");
        }
        static void ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Log.Error(e.Exception, "Unhandled Exception");
            MessageBox.Show(e.Exception.Message, "Unhandled Exception");
        }

    }
}
