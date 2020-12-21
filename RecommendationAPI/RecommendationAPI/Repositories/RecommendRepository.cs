using MongoDB.Driver;
using RecommendationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendationAPI.Repositories
{
    public class RecommendRepository : IRecommendRepository
    {
        private readonly RecommendContext context;

        public RecommendRepository(RecommendContext _context)
        {
            this.context = _context;
        }
        public Recommend AddRecommands(Recommend recommend)
        {
            var recommends = this.context.Recommendations.AsQueryable();
            if (recommends.Count() == 0)
            {
                recommend.Id = 101;
            }
            else
            {
                int maxCategoryId = recommends.Max(c => c.Id) + 1;
                recommend.Id = maxCategoryId;
            }
            context.Recommendations.InsertOne(recommend);
            return recommend;
        }

        public List<Recommend> GetRecommandsById(int id)
        {
            List<Recommend> recommends = new List<Recommend>();
            recommends = context.Recommendations.Find(name => name.Id == id).ToList();
            return recommends;
        }

        public List<Recommend> GetRecommends()
        {
            return context.Recommendations.Find(x => true).ToList();
        }

        public bool RemoveRecommend(int id, string title)
        {
            DeleteResult deleteResult = context.Recommendations.DeleteOne(c => c.Id == id && c.Title==title);
            return deleteResult.IsAcknowledged && deleteResult.DeletedCount > 0;
        }
    }
}
