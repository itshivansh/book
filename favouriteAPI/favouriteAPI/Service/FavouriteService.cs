using favouriteAPI.Exceptions;
using favouriteAPI.Models;
using favouriteAPI.Repository;
using System.Collections.Generic;
using System.Linq;

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
            var availability = repo.GetFavourites().Where(c => c.Id == favourite.Id).FirstOrDefault();
            //var availability = repo.IsFavouriteExist(favourite);
            if (availability==null)
            {
                return repo.AddFavourite(favourite);

            }
            else
            {
                throw new AlreadyFavourite(" already  Favourite");
            }
           
        }

        public bool DeleteFavourite(int id, string title)
        {         
              var availability = repo.IsFavouriteExistWithId(id);
                if (availability)
                {
                return repo.DeleteFavourite(id, title);
                }
                else
                {
                    throw new DatabaseNotFound("favourite does not exist");
                }
                
        }

        public List<Favourite> GetFavourite(int id)
        {
            var availability = repo.IsFavouriteExistWithId(id);
            if (availability)
            {
                return repo.GetFavourite(id);
            }
            else
            {
                throw new DatabaseNotFound("data does not Exist");
            }
            
        }

        public List<Favourite> GetFavourites()
        {
            return repo.GetFavourites();
        }
    }
}
