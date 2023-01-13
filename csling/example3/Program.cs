using System;
using System.Collections.Generic;
using System.Text;

namespace Csling
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieDB db = new MovieDB();
            IEnumerable<Movie> query = 
            db.Movies.Where(m=> m.Title.Startwith("Star"))
            .OrderBy(m => m.ReleaseDate.Year);

            foreach (var movie in query)
            {
                Console.WriteLine(movie.Title);
            }

        }


    }
}

namespace Extensions
{

}