using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Ivanovi_s_Family
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double firstGiftPrice = double.Parse(Console.ReadLine());
            double secondGiftPrice = double.Parse(Console.ReadLine());
            double thirdGiftPrice = double.Parse(Console.ReadLine());

            double totalGiftsPrice = firstGiftPrice + secondGiftPrice + thirdGiftPrice;
            double donation = (budget - totalGiftsPrice) - (0.1 * (budget - totalGiftsPrice));

            Console.WriteLine($"{donation:F2}");
        }
    }
}
