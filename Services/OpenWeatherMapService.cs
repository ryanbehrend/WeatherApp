using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;

namespace FinalProject.Services
{
    public class OpenWeatherMapService : IWeatherService
    {
        private readonly string _apiKey;
        private readonly HttpClient _http;

        public OpenWeatherMapService(string apiKey)
        {
            _apiKey = "da591e09574f5f39637af0dc24566aa0"; // apiKey;
            _http = new HttpClient
            {
                BaseAddress = new Uri("https://api.openweathermap.org/data/2.5/")
            };
        }

        public WeatherReport GetCurrentWeather(Location location)
        {
            // Build URL: either zip or city query
            var query = BuildLocationQuery(location);
            var url   = $"weather?{query}&appid={_apiKey}&units=imperial";  // or metric/K
            var json  = _http.GetStringAsync(url).Result;
            using var doc = JsonDocument.Parse(json);

            var root    = doc.RootElement;
            var main    = root.GetProperty("main");
            var weather = root.GetProperty("weather")[0];
            var wind    = root.GetProperty("wind");

            return new WeatherReport
            {
                City = city,
                Temperature = main.GetProperty("temp").GetDouble(),
                MinTemperature = main.GetProperty("temp_min").GetDouble(),
                MaxTemperature = main.GetProperty("temp_max").GetDouble(),
                Humidity = main.GetProperty("humidity").GetInt32(),
                WindSpeed = wind.GetProperty("speed").GetDouble(),
                Condition = weather.GetProperty("description").GetString(),
                Precipitation = main.GetProperty("precipitation").GetString()
            };
        }

        public List<WeatherReport> Get5DayForecast(Location location)
        {
            var query = BuildLocationQuery(location);
            var url   = $"forecast?{query}&appid={_apiKey}&units=imperial";
            var json  = _http.GetStringAsync(url).Result;
            using var doc = JsonDocument.Parse(json);

            var list    = doc.RootElement.GetProperty("list").EnumerateArray();
            var city    = doc.RootElement.GetProperty("city").GetProperty("name").GetString();
            var results = new List<WeatherReport>();

            foreach (var item in list)
            {
                var main    = item.GetProperty("main");
                var weather = item.GetProperty("weather")[0];
                var wind    = item.GetProperty("wind");

                results.Add(new WeatherReport
                {
                    City = city,
                    Temperature = main.GetProperty("temp").GetDouble(),
                    MinTemperature = main.GetProperty("temp_min").GetDouble(),
                    MaxTemperature = main.GetProperty("temp_max").GetDouble(),
                    Humidity = main.GetProperty("humidity").GetInt32(),
                    WindSpeed = wind.GetProperty("speed").GetDouble(),
                    Condition = weather.GetProperty("description").GetString(),
                    Precipitation = main.GetProperty("precipitation").GetString()
                });
            }

            return results;
        }

        private string BuildLocationQuery(Location loc)
        {
            return !string.IsNullOrWhiteSpace(loc.ZipCode)
                ? $"zip={loc.ZipCode},{loc.Country}"
                : $"q={loc.City},{loc.Country}";
        }
    }
}
