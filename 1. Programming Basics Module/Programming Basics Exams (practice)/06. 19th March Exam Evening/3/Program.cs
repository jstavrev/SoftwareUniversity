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
            string season = Console.ReadLine();
            double monthlyKM = double.Parse(Console.ReadLine());

            double perKM = 0.0;
            if (monthlyKM <= 5000)
            {
                switch (season)
                {
                    default: perKM = 0.75; break;
                    case "Winter": perKM = 1.05; break;
                    case "Summer": perKM = 0.90; break;                
                }
            }
            else if (monthlyKM > 5000 && monthlyKM <=10000)
            {
                switch (season)
                {
                    default: perKM = 0.95; break;
                    case "Winter": perKM = 1.25; break;
                    case "Summer": perKM = 1.10; break;
                }
            }
            else if (monthlyKM > 10000 && monthlyKM <= 20000)
            {
                perKM = 1.45;
            }

            double afterTaxes = (monthlyKM * 4 * perKM) - ((monthlyKM * 4 * perKM) * 0.1);
            Console.WriteLine($"{afterTaxes:f2}");
        }
    }
}
