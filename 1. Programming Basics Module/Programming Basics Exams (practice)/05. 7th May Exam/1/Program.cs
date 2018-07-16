using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerAmount = double.Parse(Console.ReadLine());
            double wineAmount = double.Parse(Console.ReadLine());
            double rakiqAmount = double.Parse(Console.ReadLine());
            double whiskeyAmount = double.Parse(Console.ReadLine());

            double rakiqPrice = whiskeyPrice / 2;
            double winePrice = rakiqPrice - (rakiqPrice * 0.4);
            double beerPrice = rakiqPrice - (rakiqPrice * 0.8);

            double priceTotal = (rakiqPrice * rakiqAmount) + (whiskeyPrice * whiskeyAmount) + (winePrice * wineAmount) + (beerPrice * beerAmount);
            Console.WriteLine($"{priceTotal:F2}");
        }
    }
}
