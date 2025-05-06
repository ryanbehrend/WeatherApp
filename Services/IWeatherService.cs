using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public interface IWeatherService
    {
        WeatherReport GetCurrentWeather(Location location);
        List<WeatherReport> Get5DayForecast(Location location);
    }
}
