using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FinalProject.Models;
using FinalProject.Services;

namespace FinalProject.Controllers
{
    public class WeatherAppController
    {
        private readonly IWeatherService _weatherService;
        private readonly IFavoritesManager _favoritesManager;
        private Location _currentLocation;

        public WeatherAppController(
            IWeatherService weatherService,
            IFavoritesManager favoritesManager)
        {
            _weatherService = weatherService ?? throw new ArgumentNullException(nameof(weatherService));
            _favoritesManager = favoritesManager ?? throw new ArgumentNullException(nameof(favoritesManager));

            _favoritesManager.Load();
        }

        public async Task<WeatherReport> SearchAsync(string cityOrZip)
        {
            if (string.IsNullOrWhiteSpace(cityOrZip))
                throw new ArgumentException("City or ZIP is required", nameof(cityOrZip));

            if (char.IsDigit(cityOrZip[0]))
                _currentLocation = new ZipCodeLocation(cityOrZip);
            else
                _currentLocation = new CityLocation(cityOrZip);

            return await _weatherService.GetCurrentWeatherAsync(_currentLocation).ConfigureAwait(false);
        }

        public async Task<WeatherReport> RefreshAsync()
        {
            if (_currentLocation == null)
                throw new InvalidOperationException("No location to refresh; call SearchAsync first.");

            return await _weatherService.GetCurrentWeatherAsync(_currentLocation).ConfigureAwait(false);
        }

        public async Task<List<WeatherReport>> Get5DayForecastAsync()
        {
            if (_currentLocation == null)
                throw new InvalidOperationException("No location selected; call SearchAsync first.");

            return await _weatherService.Get5DayForecastAsync(_currentLocation).ConfigureAwait(false);
        }

        public void AddCurrentToFavorites()
        {
            if (_currentLocation == null) return;

            _favoritesManager.AddFavorite(_currentLocation);
            _favoritesManager.Save();
        }

        public void RemoveFromFavorites(Location location)
        {
            if (location == null) return;

            _favoritesManager.RemoveFavorite(location);
            _favoritesManager.Save();
        }

        public void ChangeUnits(string units)
        {
            if (_weatherService is OpenWeatherMapService ows)
                ows._units = units;
        }

        public IReadOnlyList<Location> GetFavorites() => _favoritesManager.GetFavorites();
    }
}