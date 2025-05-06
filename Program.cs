using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.Configuration;
using FinalProject.Services;
using FinalProject.Controllers;

namespace FinalProject
{
    internal static class Program
    {
        /// <summary>  
        /// The main entry point for the application.  
        /// </summary>  
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var config = AppConfig.Load();
            var weatherService = new OpenWeatherMapService(config.OpenWeatherApiKey);

            var favoritesManager = new FavoritesManager(config.FavoritesFilePath);
            favoritesManager.Load();
            var controller = new WeatherAppController(weatherService, favoritesManager);

            Application.Run(new WeatherApp(controller));
        }
    }
}
