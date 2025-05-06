using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Configuration
{
    public class AppConfig
    {
        public string OpenWeatherApiKey { get; set; }
        public string DefaultCountryCode { get; set; } = "US;";
        public string Units { get; set; } = "imperial";
        public static AppConfig Load(string path);
        public void Save(string path);
    }
}
