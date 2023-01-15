using System;
using System.Diagnostics;
using System.Dynamic;

namespace csdlr
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic expando = new ExpandoObject();
            expando.Name = "Anthony";
            expando.Speak = new Action(() => Console.WriteLine(expando.Name));
        }
    }
}