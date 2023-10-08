namespace party.windows.infrastructure.extensions
{
    using System.IO;
    using party.core.constants;
    using party.core.settings;

    public static class ConfigurationExtension
    {
        public static bool ExistsConfiguration(this SettingsAppData configuracion)
        {
            return Directory.Exists(configuracion?.EventPath);
        }
        public static bool HasBasicValues(this SettingsAppData configuracion)
        {
            bool hasBasicValues = configuracion.ExistsConfiguration() && configuracion.DatabaseName.EndsWith(SQLiteConstants.DefaultExtension);
            return hasBasicValues;
        }
        public static void RefreshFromInfo(this SettingsAppData configuracion)
        {
            //Generate settings file in folder

        }
    }
}
