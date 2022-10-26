namespace party.core.model
{
    using System.IO;
    using party.core.constants;

    public class Configuracion
    {
        public string EventPath { get; set; }
        public string ConfigurationFilename => Path.Combine(EventPath, "appsettings.json");
        public string DatabaseName { get; set; }
        public string CSVSeparationLetter { get; set; }
        public string Event { get; set; }
        public string Title { get; set; }
        public string BackgroundImage { get; set; }
    }
}
