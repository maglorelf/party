namespace party.windows.domain
{
    using System;
    using System.IO;
    using party.core.settings;
    using party.windows.configuration.settings;

    public class EventRepository
    {
        public SettingsAppData Configuration { get; protected set; }
        public void Initialize(string path)
        {
            CreateFolder(path);
            Configuration = GenerateConfigurationFile(path);
        }

        private static SettingsAppData GenerateConfigurationFile(string path)
        {
            SettingsAppData configuration = GenerateDefaultConfiguration(path);
            SettingsManager.SaveConfiguration(configuration);
            return configuration;

        }
        private static SettingsAppData GenerateDefaultConfiguration(string path)
        {
            SettingsAppData configuracion = new()
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
