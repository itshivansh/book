using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendationAPI.Exceptions
{
    public class RecommendNotAdded:ApplicationException
    {
        public RecommendNotAdded()
        {

        }
        public RecommendNotAdded(string message) : base(message) { }
    }
}
