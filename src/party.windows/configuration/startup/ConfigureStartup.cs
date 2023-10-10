namespace party.windows.configuration.startup
{
    using System.IO;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using party.core.settings;
    using party.service;
    using party.service.data;
    using party.windows.forms;
    using Serilog;

    public static class ConfigureStartup
    {
        public static IHost Startup()
        {
            IConfiguration configuration = ConfigureSetup();
            Log.Logger = new LoggerConfiguration()
                            .ReadFrom.Configuration(configuration)
                            .CreateLogger();
            IHost host = Host.CreateDefaultBuilder()
                 .UseSerilog()
                 .ConfigureServices((context, services) =>
                 {
                     services.ConfigureServices(configuration);
                 })

                .Build();
            return host;
        }
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<SettingsAppData>(configuration.GetSection("SettingsApp"));
            services.AddScoped<AttendanceForm>();
            services.AddScoped<IProceso, Proceso>();
            services.AddScoped<IDataService, DataService>();
            services.AddScoped<ICSVService, CSVService>();
        }
        public static IConfiguration ConfigureSetup()
        {
            var builder = new ConfigurationBuilder();
            IConfiguration configuration = builder.SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                        .Build();
            return configuration;
        }
    }
}
