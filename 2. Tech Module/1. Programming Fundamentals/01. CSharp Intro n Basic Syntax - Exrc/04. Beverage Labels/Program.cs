using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string label = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int kcalPer100 = int.Parse(Console.ReadLine());
            int sugarPer100 = int.Parse(Console.ReadLine());

            double kcalTotal = ((double)volume / 100) * kcalPer100;
            double sugarTotal = ((double)volume / 100) * sugarPer100;

            Console.WriteLine($"{volume}ml {label}:");
            Console.WriteLine($"{kcalTotal}kcal, {sugarTotal}g sugars");
        }
    }
}