namespace party.windows
{
    using System;
    using System.Windows.Forms;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using party.windows.configuration.startup;
    using party.windows.forms;

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

            IHost host = ConfigureStartup.Startup();

            var mainForm = ActivatorUtilities.CreateInstance<Asistencia >(host.Services);
            Application. Run(mainForm);

        }


    }
}
