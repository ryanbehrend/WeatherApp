using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
