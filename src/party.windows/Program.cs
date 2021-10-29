using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using party.windows.configuration.startup;
using party.windows.forms;
using System;
using System.Windows.Forms;

namespace party.windows
{
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
