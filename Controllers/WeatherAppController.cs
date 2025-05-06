using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    public class WeatherAppController
    {
        private readonly IWeatherService _weatherService;
        private readonly IFavoritesManager _favoritesManager;
        private Location _currentLocation;
        public WeatherAppController(IWeatherService weatherService, IFavoritesManager favoritesManager)
        {
            _weatherService = weatherService;
            _favoritesManager = favoritesManager;
            _favoritesManager.Load();
        }
        public WeatherReport Search(string cityOrZip)
        {
            _currentLocation =
                char.IsDigit(cityOrZip[0])
                ? (Location)new ZipCodeLocation(cityOrZip)
                : new CityLocation(cityOrZip);

            return _weatherService.GetCurrentWeather(_currentLocation);
        }
        public WeatherReport Refresh()
        {
            if (_currentLocation == null)
                throw new InvalidOperationException("No location selected");
            return _weatherService.GetCurrentWeather(_currentLocation);
        }
        public List<WeatherReport> Get5DayForecast()
        {
            if (_currentLocation == null)
                throw new InvalidOperationException("No location selected");
            return _weatherService.Get5DayForecast(_currentLocation);
        }
        public void AddToFavorites()
        {
            if (_currentLocation == null) return;
            _favoritesManager.AddFavorite(_currentLocation);
            _favoritesManager.Save();
        }
        public void RemoveFromFavorites(Location location)
        {
            _favoritesManager.RemoveFavorite(location);
            _favoritesManager.Save();
        }
        public IReadOnlyList<Location> GetFavorites() => _favoritesManager.GetFavorites();
    }
}
