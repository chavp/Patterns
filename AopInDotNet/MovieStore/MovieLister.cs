using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AopInDotNet.MovieStore
{
    public class MovieLister //MovieLister Model
    {
        public IMovieFinder MovieFinder { protected get; set; }

        public IEnumerable<Movie> MoviesDirectedBy(string director)
        {
            var movies = from n in MovieFinder.FindAll()
                         where n.Director.Equals(director, StringComparison.CurrentCultureIgnoreCase)
                         select n;
            return movies;
        }
    }
}
