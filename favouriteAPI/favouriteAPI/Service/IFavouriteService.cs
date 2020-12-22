using favouriteAPI.Models;
using System.Collections.Generic;

namespace favouriteAPI.Service
{
    public interface IFavouriteService
    {
        List<Favourite> GetFavourites();
        List<Favourite> GetFavourite(int id);
        Favourite AddFavourite(Favourite favourite);
        bool DeleteFavourite(int id, string title);
    }
}
