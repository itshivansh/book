using RecommendationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendationAPI.Services
{
    public interface IRecommendService
    {
        Recommend AddRecommands(Recommend recommend);
        List<Recommend> GetRecommandsById(int id);
        List<Recommend> GetRecommends();
        bool RemoveRecommend(int id, string title);
    }
}
