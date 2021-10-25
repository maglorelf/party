﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using party.core.model;
using party.service;
using party.service.data;
using party.windows.forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace party.windows.configuration.startup
{
    public static class ConfigureStartup

    {
        public static IHost Startup()
        {
            IConfiguration configuration = ConfigureSetup();

            IHost host = Host.CreateDefaultBuilder()
                 .ConfigureServices((context, services) => {
                     services.ConfigureServices(configuration);
                 })
                 
                .Build();
            return host;
        }
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<Configuracion>(configuration.GetSection("SettingsApp"));
            services.AddScoped<Asistencia>();

            services.AddScoped<IProceso, Proceso>();
            services.AddScoped<IDataService, DataService>();
            services.AddScoped<ICSVService, CSVService>();
        }
        public static IConfiguration ConfigureSetup()
        {
            var builder = new ConfigurationBuilder();
        IConfiguration configuration=    builder.SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build ();
            return configuration;
        }
    }
}
