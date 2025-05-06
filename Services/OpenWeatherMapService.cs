using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using FinalProject.Models;
using FinalProject.Services;
using FinalProject.Controllers;

namespace FinalProject.Services
{
    public class OpenWeatherMapService : IWeatherService
    {
        private readonly string _apiKey;
        private readonly HttpClient _http;

        public OpenWeatherMapService(string apiKey)
        {
            _apiKey = apiKey;
            _http = new HttpClient
            {
                BaseAddress = new Uri("https://api.openweathermap.org/data/2.5/")
            };
        }

        public WeatherReport GetCurrentWeather(Location location)
        {
            var query = BuildLocationQuery(location);
            var url = $"weather?{query}&appid={_apiKey}&units=imperial";
            var json = _http.GetStringAsync(url).Result;
            var doc = JsonDocument.Parse(json);

            var root = doc.RootElement;
            var city = doc.RootElement.GetProperty("city").GetProperty("name").GetString();
            var main = root.GetProperty("main");
            var weather = root.GetProperty("weather")[0];
            var wind = root.GetProperty("wind");

            return new WeatherReport
            {
                City = city,
                Temperature = main.GetProperty("temp").GetDouble(),
                MinTemperature = main.GetProperty("temp_min").GetDouble(),
                MaxTemperature = main.GetProperty("temp_max").GetDouble(),
                Humidity = main.GetProperty("humidity").GetInt32(),
                WindSpeed = wind.GetProperty("speed").GetDouble(),
                Condition = weather.GetProperty("description").GetString(),
                Precipitation = root.TryGetProperty("rain", out var rain) ? rain.GetProperty("1h").GetDouble().ToString() : "0"
            };
        }

        public List<WeatherReport> Get5DayForecast(Location location)
        {
            var query = BuildLocationQuery(location);
            var url = $"forecast?{query}&appid={_apiKey}&units=imperial";
            var json = _http.GetStringAsync(url).Result;
            var doc = JsonDocument.Parse(json);

            var list = doc.RootElement.GetProperty("list").EnumerateArray();
            var city = doc.RootElement.GetProperty("city").GetProperty("name").GetString();
            var results = new List<WeatherReport>();

            foreach (var item in list)
            {
                var main = item.GetProperty("main");
                var weather = item.GetProperty("weather")[0];
                var wind = item.GetProperty("wind");

                results.Add(new WeatherReport
                {
                    City = city,
                    Temperature = main.GetProperty("temp").GetDouble(),
                    MinTemperature = main.GetProperty("temp_min").GetDouble(),
                    MaxTemperature = main.GetProperty("temp_max").GetDouble(),
                    Humidity = main.GetProperty("humidity").GetInt32(),
                    WindSpeed = wind.GetProperty("speed").GetDouble(),
                    Condition = weather.GetProperty("description").GetString(),
                    Precipitation = item.TryGetProperty("rain", out var rain) ? rain.GetProperty("3h").GetDouble().ToString() : "0"
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
