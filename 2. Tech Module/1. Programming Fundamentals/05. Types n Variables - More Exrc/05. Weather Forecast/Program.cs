using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            if (sbyte.TryParse(n, out sbyte Byte))
            {
                Console.WriteLine("Sunny");
            }
            else if (int.TryParse(n, out int Integer))
            {
                Console.WriteLine("Cloudy");
            }
            else if (long.TryParse(n, out long Long))
            {
                Console.WriteLine("Windy");
            }
            else 
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}
