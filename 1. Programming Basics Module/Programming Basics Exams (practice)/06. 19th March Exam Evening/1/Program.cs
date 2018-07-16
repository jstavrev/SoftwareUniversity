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
            double size = double.Parse(Console.ReadLine());
            double kgM = double.Parse(Console.ReadLine());
            double waste = double.Parse(Console.ReadLine());

            double grapesTotal = (size * kgM) - waste;
            double forRakiq = grapesTotal - (grapesTotal * 0.55);
            double rakiqMade = (forRakiq / 7.5);
            double forSale = grapesTotal - (grapesTotal * 0.45);

            double rakiqIncome = rakiqMade * 9.8;
            double saleIncome = forSale * 1.5;

            Console.WriteLine($"{rakiqIncome:F2}");
            Console.WriteLine($"{saleIncome:F2}");

        }
    }
}
