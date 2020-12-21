using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendationAPI.Models
{
    public class RecommendContext
    {
        private readonly IMongoDatabase database;
        MongoClient client;
        //constructor
        public RecommendContext(IConfiguration configuration)
        {
            client = new MongoClient(configuration.GetSection("MongoDB:ConnectionString").Value);
            database = client.GetDatabase(configuration.GetSection("MongoDB:Database").Value);
        }
        // mongocollection for Recommends
        public IMongoCollection<Recommend> Recommendations => database.GetCollection<Recommend>("Recommendations");
    }
}
