using favouriteAPI.Models;
using System.Collections.Generic;

namespace favouriteAPI.Repository
{
    public interface IFavouriteRepo
    {
        List<Favourite> GetFavourites();
        List<Favourite> GetFavourite(int id);
        Favourite AddFavourite(Favourite favourite);
        bool DeleteFavourite(int id, string title);
        public bool IsFavouriteExistWithId(int id);
        public bool IsFavouriteExist(Favourite favourite);
    }
}
