namespace csling;
class Program
{
    static void Main(string[] args)
    {
        IEnumerable<string> cities = new [] {"Ghent", "London", "Las Vegas", "Atlantas"};

        foreach (var city in cities)
        {
            Console.WriteLine(city);
            
        }
        }
}

