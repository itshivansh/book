using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendationAPI.Exceptions
{
    public class RecommendNotFound:ApplicationException
    {
        public RecommendNotFound()
        {

        }
        public RecommendNotFound(string message) : base(message) { }
    }
}
