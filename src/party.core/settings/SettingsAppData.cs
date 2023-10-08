namespace party.core.settings
{
    using System;
    using System.IO;

    public class SettingsAppData
    {
        public string EventPath { get; set; }
        public string ConfigurationFilename => Path.Combine(EventPath, "appsettings.json");
        public string DatabaseName { get; set; }
        public string CSVSeparationLetter { get; set; }
        public string BackgroundImage { get; set; }
        public string Event { get; set; }
        public string Title { get; set; }
        public Guid EventId { get; set; }
        public string EventTitle { get; set; }
        public Guid RouteId { get; set; }
        public string RouteName { get; set; }
    }
}
