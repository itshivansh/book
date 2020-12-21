using RecommendationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendationAPI.Repositories
{
    public interface IRecommendRepository
    {
        Recommend AddRecommands(Recommend recommend);
        List<Recommend> GetRecommandsById(int id);
        List<Recommend> GetRecommends();
        bool RemoveRecommend(int id, string title);
        //public bool IsRecommendExistWithId(int id);
        //public bool IsRecommendExist(Recommend recommend);
    }
}
