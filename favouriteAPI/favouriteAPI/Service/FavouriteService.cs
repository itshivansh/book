using favouriteAPI.Models;
using favouriteAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace favouriteAPI.Service
{
    public class FavouriteService : IFavouriteService
    {
        private readonly IFavouriteRepo repo;
        public FavouriteService(IFavouriteRepo _repo)
        {
            repo = _repo;
        }
        public Favourite AddFavourite(Favourite favourite)
        {
            return repo.AddFavourite(favourite);
        }

        public bool DeleteFavourite(int id, string title)
        {
            return repo.DeleteFavourite(id, title);
        }

        public List<Favourite> GetFavourite(int id)
        {
            return repo.GetFavourite(id);
        }

        public List<Favourite> GetFavourites()
        {
            return repo.GetFavourites();
        }
    }
}
