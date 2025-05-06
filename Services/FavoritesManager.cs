using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using FinalProject.Models;

namespace FinalProject.Services
{
    internal class FavoritesManager : IFavoritesManager
    {
        private readonly string _filePath;
        private readonly List<Location> _favorites = new List<Location>();

        public FavoritesManager(string filePath)
        {
            _filePath = filePath;
        }

        public IReadOnlyList<Location> GetFavorites() => _favorites.AsReadOnly();

        public void AddFavorite(Location location)
        {
            if (_favorites.Any(f => f.GetQueryString() == location.GetQueryString()))
                return;
            _favorites.Add(location);
        }

        public void RemoveFavorite(Location location)
        {
            _favorites.RemoveAll(f => f.GetQueryString() == location.GetQueryString());
        }

        public void Save()
        {
            try
            {
                var raw = _favorites
                    .Select(loc => new RawLocation
                    {
                        City = loc.City,
                        ZipCode = loc.ZipCode,
                        Country = loc.Country
                    })
                    .ToList();

                var options = new JsonSerializerOptions { WriteIndented = true };
                var json = JsonSerializer.Serialize(raw, options);
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Failed to save favorites: {ex.Message}");
            }
        }

        public void Load()
        {
            if (!File.Exists(_filePath))
                return;

            try
            {
                var json = File.ReadAllText(_filePath);
                var items = JsonSerializer.Deserialize<List<RawLocation>>(json);
                if (items == null) return;

                _favorites.Clear();
                foreach (var raw in items)
                {
                    Location loc;
                    if (!string.IsNullOrWhiteSpace(raw.ZipCode))
                    {
                        loc = new ZipCodeLocation(raw.ZipCode, raw.Country);
                    }
                    else
                    {
                        loc = new CityLocation(raw.City, raw.Country);
                    }
                    _favorites.Add(loc);
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Failed to load favorites: {ex.Message}");
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
