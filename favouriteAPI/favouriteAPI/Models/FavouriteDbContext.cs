using favouriteAPI.Exceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace favouriteAPI.Models
{
    public class FavouriteDbContext : DbContext
    {
        MongoClient client;
        IMongoDatabase database;
        public FavouriteDbContext(IConfiguration config)
        {
            client = new MongoClient(config.GetSection("MongoDB:server").Value);
            database = client.GetDatabase(config.GetSection("MongoDB:db").Value);
        }
        public IMongoCollection<Favourite> Fav => database.GetCollection<Favourite>("Recommendation");

        //    public FavouriteDbContext()
        //    { }
        //    public FavouriteDbContext(DbContextOptions options):base(options)
        //    {
        //        try
        //        {
        //            this.Database.EnsureCreated();
        //        }
        //        catch
        //        {
        //            throw new DatabaseNotFound();
        //        }
        //    }
        //    public DbSet<Favourite> Favourites { get; set; }

        //    protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    {
        //        modelBuilder.Entity<Favourite>()
        //            .HasKey(c => new { c.Author,c.Title,c.Description,c.PublishedAt,c.UserName });
        //    }
    }
}
