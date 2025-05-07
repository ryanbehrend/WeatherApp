using System.Collections.Generic;
using FinalProject.Models;

namespace FinalProject.Services
{
    public interface IFavoritesManager
    {
        IReadOnlyList<Location> GetFavorites();

        void AddFavorite(Location location);
        void RemoveFavorite(Location location);
        void Load();
        void Save();
    }
}