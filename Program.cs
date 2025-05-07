using System;
using System.Windows.Forms;
using FinalProject.Configuration;
using FinalProject.Controllers;
using FinalProject.Services;
using FinalProject.UI;

namespace FinalProject
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var config = AppConfig.Load();

            var weatherSvc = new OpenWeatherMapService(config.OpenWeatherApiKey);
            var favMgr = new FavoritesManager(config.FavoritesFilePath);
            favMgr.Load();

            var controller = new WeatherAppController(weatherSvc, favMgr);
            
            Application.Run(new WeatherApp(controller));
        }
    }
}
