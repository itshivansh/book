using favouriteAPI.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace favouriteAPI.Repository
{
    public class FavouriteRepo : IFavouriteRepo
    {
        private readonly FavouriteDbContext db;
        public FavouriteRepo(FavouriteDbContext dbcontext)
        {
            db = dbcontext;
        }
        public Favourite AddFavourite(Favourite favourite)
        {
            db.Fav.InsertOne(favourite);
           // db.Favourites.Add(favourite);
            //db.SaveChanges();
            return favourite;
        }

        public bool DeleteFavourite(int id, string title)
        {
            DeleteResult deleteResult = db.Fav.DeleteOne(c => c.Id == id);
            return deleteResult.IsAcknowledged && deleteResult.DeletedCount > 0;

            //var article = db.Favourites.Where(x => x.Id == id && x.Title == title).FirstOrDefault();
            //if (article != null)
            //{
            //    db.Favourites.Remove(article);
            //    db.SaveChanges();
            //    return true;
            //}
            //return false;
        }

        public List<Favourite> GetFavourite(int id)
        {

            List<Favourite> favourite = new List<Favourite>();
            favourite = db.Fav.Find(name => name.Id == id).ToList();
            return favourite;

            //List<Favourite> favourites = new List<Favourite>();
            //favourites = db.Favourites.Where(x => x.Id == id).ToList();
            //return favourites;
        }

        public List<Favourite> GetFavourites()
        {

            return db.Fav.Find(favourite => true).ToList();

            //return db.Favourites.ToList();
        }

        public bool IsFavouriteExist(Favourite favourite)
        {
            var favouriteExist = db.Fav.Find(favourites => favourites.Id == favourite.Id);
            if (favouriteExist != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFavouriteExistWithId(int id)
        {
            var favouriteExist = db.Fav.Find(x => x.Id == id).FirstOrDefault();
            if (favouriteExist != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
