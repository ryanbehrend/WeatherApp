using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using FinalProject.Models;

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

        public async Task<WeatherReport> GetCurrentWeatherAsync(Location location)
        {
            var url = $"weather?{location.GetQueryString()}&appid={_apiKey}&units=imperial";
            HttpResponseMessage response = await _http.GetAsync(url).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            using (JsonDocument doc = JsonDocument.Parse(json))
            {
                JsonElement root = doc.RootElement;
                JsonElement main = root.GetProperty("main");
                JsonElement weather = root.GetProperty("weather")[0];
                JsonElement wind = root.GetProperty("wind");

                return new WeatherReport
                {
                    City = root.GetProperty("name").GetString(),
                    DateTime = DateTimeOffset
                                              .FromUnixTimeSeconds(root.GetProperty("dt").GetInt64())
                                              .DateTime,
                    Temperature = main.GetProperty("temp").GetDouble(),
                    FeelsLikeTemperature = main.GetProperty("feels_like").GetDouble(),
                    MinTemperature = main.GetProperty("temp_min").GetDouble(),
                    MaxTemperature = main.GetProperty("temp_max").GetDouble(),
                    Humidity = main.GetProperty("humidity").GetInt32(),
                    WindSpeed = wind.GetProperty("speed").GetDouble(),
                    Condition = weather.GetProperty("description").GetString(),
                    Precipitation = root.TryGetProperty("rain", out JsonElement rain)
                                              ? rain.GetProperty("1h").GetDouble().ToString()
                                              : "0"
                };
            }
        }

        public async Task<List<WeatherReport>> Get5DayForecastAsync(Location location)
        {
            var url = $"forecast?{location.GetQueryString()}&appid={_apiKey}&units=imperial";
            HttpResponseMessage response = await _http.GetAsync(url).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            using (JsonDocument doc = JsonDocument.Parse(json))
            {
                JsonElement root = doc.RootElement;
                JsonElement listElem = root.GetProperty("list");
                string cityName = root.GetProperty("city").GetProperty("name").GetString();
                var results = new List<WeatherReport>();

                foreach (JsonElement item in listElem.EnumerateArray())
                {
                    JsonElement main = item.GetProperty("main");
                    JsonElement weather = item.GetProperty("weather")[0];
                    JsonElement wind = item.GetProperty("wind");

                    results.Add(new WeatherReport
                    {
                        City = cityName,
                        DateTime = DateTimeOffset
                                                  .FromUnixTimeSeconds(item.GetProperty("dt").GetInt64())
                                                  .DateTime,
                        Temperature = main.GetProperty("temp").GetDouble(),
                        FeelsLikeTemperature = main.GetProperty("feels_like").GetDouble(),
                        MinTemperature = main.GetProperty("temp_min").GetDouble(),
                        MaxTemperature = main.GetProperty("temp_max").GetDouble(),
                        Humidity = main.GetProperty("humidity").GetInt32(),
                        WindSpeed = wind.GetProperty("speed").GetDouble(),
                        Condition = weather.GetProperty("description").GetString(),
                        Precipitation = item.TryGetProperty("rain", out JsonElement rain)
                                                  ? rain.GetProperty("3h").GetDouble().ToString()
                                                  : "0"
                    });
                }

                return results;
            }
        }
    }
}
