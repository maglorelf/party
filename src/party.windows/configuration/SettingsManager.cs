using party.core.model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace party.windows.configuration
{
    public class SettingsManager
    {
        public static string ReadSetting(string key)
        {
            string result = string.Empty;
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                result = appSettings[key] ?? "Not Found";

            }
            catch (ConfigurationErrorsException)
            {

            }
            return result;
        }
        public static void SaveConfiguration(Configuracion configuration)
        {
            var props = DictionaryFromType(configuration);
            foreach (var prop in props)
            {
                SetAppSettingValue(prop.Key, prop.Value.ToString());
            }

        }

        private static Dictionary<string, object> DictionaryFromType(object atype)
        {
            if (atype == null)
            {
                return new Dictionary<string, object>();
            }
            Type t = atype.GetType();
            PropertyInfo[] props = t.GetProperties();
            Dictionary<string, object> dict = new(); // reflection
            foreach (PropertyInfo prp in props)
            {
                object value = prp.GetValue(atype, Array.Empty<object>());
                dict.Add(prp.Name, value);
            }
            return dict;
        }
        public static void SetAppSettingConfiguracionValues(Configuracion value, string appSettingsJsonFilePath = null)
        {
            if (appSettingsJsonFilePath == null)
            {
                appSettingsJsonFilePath = System.IO.Path.Combine(System.AppContext.BaseDirectory, "appsettings.json");
            }

            var json = System.IO.File.ReadAllText(appSettingsJsonFilePath);
            AppSettings jsonObj = JsonSerializer.Deserialize<AppSettings>(json);

            //       jsonObj[key] = value;
            jsonObj.SettingsApp = value;
            string output = JsonSerializer.Serialize(jsonObj, new JsonSerializerOptions { WriteIndented = true });

            System.IO.File.WriteAllText(appSettingsJsonFilePath, output);
        }
        public static void SetAppSettingValue(string key, string value, string appSettingsJsonFilePath = null)
        {
            if (appSettingsJsonFilePath == null)
            {
                appSettingsJsonFilePath = System.IO.Path.Combine(System.AppContext.BaseDirectory, "appsettings.json");
            }

            var json = System.IO.File.ReadAllText(appSettingsJsonFilePath);
            AppSettings jsonObj = JsonSerializer.Deserialize<AppSettings>(json);

     //       jsonObj[key] = value;

            string output = JsonSerializer.Serialize(jsonObj, new JsonSerializerOptions { WriteIndented = true });

            System.IO.File.WriteAllText(appSettingsJsonFilePath, output);
        }
        public static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
            }
        }
    }
}
