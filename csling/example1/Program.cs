using System;
using System.Collections.Generic;
using System.Text;

namespace Csling
{
    class Program
    {
        static void Main (string[] args)
        {
            IEnumerable<string> cities = new[] {"Ghent", "London", "Las Vegas", "Rivia"};

            Func<int, int> square = x => x * x;

            Console.WriteLine(square(3));

           
        }


    }
}

namespace Extensions
{
    
}