using favouriteAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace favouriteAPI.Repository
{
    public interface IFavouriteRepo
    {
        List<Favourite> GetFavourites();
        List<Favourite> GetFavourite(int id);
        Favourite AddFavourite(Favourite favourite);
        bool DeleteFavourite(int id, string title);
    }
}
