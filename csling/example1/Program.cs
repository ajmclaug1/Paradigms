using System;
using System.Collections.Generic;
using System.Text;
using Extensions;
using System.Linq;

namespace Csling
{
    class Program
    {
        static void Main (string[] args)
        {
            IEnumerable<string> cities = new[] {"Ghent", "London", "Las Vegas", "Rivia"};

            Func<int, int, int> add = (x,y) => x+y;

            Action<int> write = x => Console.WriteLine(x);

            write(add(4,6));

            IEnumerable<string> query =
                cities.Where( city => city.StartsWith("L"))
                    .OrderBy(city => city.Length);

        

            foreach (var city in query)
            {
                Console.WriteLine(city);
            }

           
        }

    }
}

namespace Extensions
{
    public static class FilterExtensions
    {
        public static IEnumerable<T> Filter<T>
        (this IEnumerable<T> input, Func<T, bool> predicate)
        {
            foreach (var item in input)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
    
    public delegate bool FilterDelegate<T>(T item);
}