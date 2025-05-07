using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using FinalProject.Models;

namespace FinalProject.Services
{
    public class FavoritesManager : IFavoritesManager
    {
        private readonly string _filePath;
        private readonly List<Location> _favorites = new List<Location>();

        public FavoritesManager(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("Favorites file path required", nameof(filePath));
            _filePath = filePath;
        }

        public IReadOnlyList<Location> GetFavorites() => _favorites.AsReadOnly();

        public void AddFavorite(Location loc)
        {
            if (_favorites.Any(f => f.GetQueryString() == loc.GetQueryString()))
                return;
            _favorites.Add(loc);
        }

        public void RemoveFavorite(Location loc)
        {
            _favorites.RemoveAll(f => f.GetQueryString() == loc.GetQueryString());
        }

        public void Load()
        {
            if (!File.Exists(_filePath))
                return;

            try
            {
                string json = File.ReadAllText(_filePath);
                var rawList = JsonSerializer.Deserialize<List<RawLocation>>(json) ?? new List<RawLocation>();
                _favorites.Clear();

                foreach (var raw in rawList)
                {
                    Location loc = !string.IsNullOrWhiteSpace(raw.ZipCode)
                        ? (Location)new ZipCodeLocation(raw.ZipCode, raw.Country)
                        : new CityLocation(raw.City, raw.Country);
                    _favorites.Add(loc);
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Failed to load favorites: {ex.Message}");
            }
        }

        public void Save()
        {
            try
            {
                var rawList = _favorites
                    .Select(loc => new RawLocation
                    {
                        City = loc.City,
                        ZipCode = loc.ZipCode,
                        Country = loc.Country
                    })
                    .ToList();

                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(rawList, options);
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Failed to save favorites: {ex.Message}");
            }
        }

        private class RawLocation
        {
            public string City { get; set; }
            public string ZipCode { get; set; }
            public string Country { get; set; }
        }
    }
}