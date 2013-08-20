using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AopInDotNet.MovieStore
{
    public class SimpleMovieFinder : IMovieFinder
    {
        public IEnumerable<Movie> FindAll()
        {
            var movies = from m in Enumerable.Range(1, 100)
                         select new Movie
                         {
                             Title = string.Format("Title{0}", m),
                             Director = string.Format("Director{0}", m),
                         };
            return movies;
        }
    }
}
