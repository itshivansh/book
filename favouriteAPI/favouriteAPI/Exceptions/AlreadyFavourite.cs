using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace favouriteAPI.Exceptions
{
    public class AlreadyFavourite: ApplicationException
    {
        public AlreadyFavourite()
        {

        }

        public AlreadyFavourite(string message):base(message)
        {

        }
    }
}
