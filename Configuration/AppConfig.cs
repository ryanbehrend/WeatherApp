using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace FinalProject.Configuration
{
    public class AppConfig
    {
        public string OpenWeatherApiKey { get; set; } = "";
        public string DefaultCountryCode { get; set; } = "US;";
        public string Units { get; set; } = "imperial";
        public string FavoritesFilePath { get; set; } = "favorites.json";
        public static AppConfig Load(string path = "appsettings.json")
        {
            try
            {
                if (!File.Exists(path))
                    return new AppConfig();

                var json = File.ReadAllText(path);
                var cfg = JsonSerializer.Deserialize<AppConfig>(json);
                return cfg ?? new AppConfig();
            }
            catch
            {
                return new AppConfig();
            }
        }
        public void Save(string path = "appsettings.json")
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var json = JsonSerializer.Serialize(this, options);
            File.WriteAllText(path, json);
        }
    }
}
