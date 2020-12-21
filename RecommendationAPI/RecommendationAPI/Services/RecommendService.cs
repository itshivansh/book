using RecommendationAPI.Exceptions;
using RecommendationAPI.Models;
using RecommendationAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendationAPI.Services
{
    public class RecommendService : IRecommendService
    {
        private readonly IRecommendRepository repository;
        private string NotFoundText = "This category id not found";
        public RecommendService(IRecommendRepository _repository)
        {
            this.repository = _repository;
        }
        public Recommend AddRecommands(Recommend recommend)
        {
            var recommends = repository.GetRecommends().Where(c => c.Id == recommend.Id).FirstOrDefault();
            if (recommends == null)
            {
                return repository.AddRecommands(recommend);
            }
            else
            {
                throw new RecommendNotAdded("This book already exists in recommendations");
            }
        }

        public List<Recommend> GetRecommandsById(int id)
        {
            List<Recommend> recommends = this.GetRecommend(id);
            if (recommends != null)
            {
                return recommends;
            }
            else
            {
                throw new RecommendNotFound(this.NotFoundText);
            }
        }

        public List<Recommend> GetRecommends()
        {
            return repository.GetRecommends();
        }

        public bool RemoveRecommend(int id, string title)
        {
            var deleteResult = repository.RemoveRecommend(id,title);
            if (deleteResult == false)
            {
                throw new RecommendNotFound(this.NotFoundText);
            }
            return deleteResult;
        }
        private List<Recommend> GetRecommend(int id)
        {
            return repository.GetRecommandsById(id);
        }
    }
}
