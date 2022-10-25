namespace party.windows.domain
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using party.core.model;
    using party.windows.configuration;

    public class EventRepository
    {
        public Configuracion Configuration { get; protected set; }
        public void Initialize(string path)
        {
            CreateFolder(path);
            Configuration = GenerateConfigurationFile(path);
        }

        private static Configuracion GenerateConfigurationFile(string path)
        {
            Configuracion configuration = GenerateDefaultConfiguration(path);
            SettingsManager.SaveConfiguration(configuration);
            return configuration;

        }
        private static Configuracion GenerateDefaultConfiguration(string path)
        {
            Configuracion configuracion = new()
            {
                EventPath = path,
                Title = "Party Events",
                DatabaseName = System.IO.Path.Combine(path, "eventDatabase.db"),
                Event = "Event Local 1",
                CSVSeparationLetter = ";",
                BackgroundImage = System.IO.Path.Combine(AppContext.BaseDirectory, "images\\Background.jpg")
            };
            return configuracion;
        }
        private static void CreateFolder(string path)
        {
            Directory.CreateDirectory(path);
        }

        public void SelectPath(string path)
        {
            if (!ExistFolder(path))
            {
                Initialize(path);
            }
            Configuration = SettingsManager.ReadConfiguration(path);
        }

        private static bool ExistFolder(string path)
        {
            return System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(path));
        }
    }
}
