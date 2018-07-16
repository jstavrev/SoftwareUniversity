using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = 0.0;
            if (budget <= 1000)
            {
                switch (season)
                {
                    case "Summer":
                        price = budget * 0.65;
                        Console.WriteLine($"Alaska - Camp - {price:F2}");
                        break;
                    case "Winter":
                        price = budget * 0.45;
                        Console.WriteLine($"Morocco - Camp - {price:F2}");
                        break;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                switch (season)
                {
                    case "Summer":
                        price = budget * 0.8;
                        Console.WriteLine($"Alaska - Hut - {price:F2}");
                        break;
                    case "Winter":
                        price = budget * 0.6;
                        Console.WriteLine($"Morocco - Hut - {price:F2}");
                        break;
                }
            }
            else
            {
                switch (season)
                {
                    case "Summer":
                        price = budget * 0.9;
                        Console.WriteLine($"Alaska - Hotel - {price:F2}");
                        break;
                    case "Winter":
                        price = budget * 0.9;
                        Console.WriteLine($"Morocco - Hotel - {price:F2}");
                        break;
                }
            }
        }
    }
}
