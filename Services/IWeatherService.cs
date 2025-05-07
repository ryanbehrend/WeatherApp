using System.Collections.Generic;
using System.Threading.Tasks;
using FinalProject.Models;

namespace FinalProject.Services
{
    public interface IWeatherService
    {
        Task<WeatherReport> GetCurrentWeatherAsync(Location location);
        Task<List<WeatherReport>> Get5DayForecastAsync(Location location);
    }
}
