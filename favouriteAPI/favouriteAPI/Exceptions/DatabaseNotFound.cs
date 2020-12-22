using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace favouriteAPI.Exceptions
{
    public class DatabaseNotFound: ApplicationException
    {
        public DatabaseNotFound() { }
        public DatabaseNotFound(string message) : base(message) { }
    }
}
