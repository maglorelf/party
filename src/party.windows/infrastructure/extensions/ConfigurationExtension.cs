namespace party.windows.infrastructure.extensions
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using party.core.constants;
    using party.core.model;

    public static class ConfigurationExtension
    {
        public static bool ExistsConfiguration(this Configuracion configuracion)
        {
            return Directory.Exists(configuracion?.EventPath);
        }
        public static bool HasBasicValues(this Configuracion configuracion)
        {
            bool hasBasicValues = configuracion.ExistsConfiguration() && configuracion.DatabaseName.EndsWith(SQLiteConstants.DefaultExtension);
            return hasBasicValues;
        }
        public static void RefreshFromInfo(this Configuracion configuracion)
        {
            //Generate settings file in folder

        }
    }
}
