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
            int tables = int.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double pokrivki = tables * (height + 2 * 0.3) * (width + 2 * 0.3);
            double kareta = tables * (height / 2) * (height / 2);

            double priceUSD = pokrivki * 7 + kareta * 9;
            double priceBGN = priceUSD * 1.85;
            
            Console.WriteLine($"{priceUSD:F2} USD");
            Console.WriteLine($"{priceBGN:0.00} BGN");

        }
    }
}
