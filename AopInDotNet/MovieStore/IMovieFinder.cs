using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AopInDotNet.MovieStore
{
    public interface IMovieFinder//MovieFinder Service
    {
        IEnumerable<Movie> FindAll();
    }
}
