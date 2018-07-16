using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int fansAmount = int.Parse(Console.ReadLine());

            double a = 0;
            double b = 0;
            double v = 0;
            double g = 0;
            for (int i = 0; i < fansAmount; i++)
            {
                string sector = Console.ReadLine();
                switch (sector)
                {
                    case "A": a++; break;
                    case "B": b++; break;
                    case "V": v++; break;
                    case "G": g++; break;
                }
            }
            double fansA = (a / fansAmount) * 100;
            double fansB = (b / fansAmount) * 100;
            double fansV = (v / fansAmount) * 100;
            double fansG = (g / fansAmount) * 100;
            double fansTotal = ((double)fansAmount / stadiumCapacity) * 100;

            Console.WriteLine($"{fansA:F2}%");
            Console.WriteLine($"{fansB:F2}%");
            Console.WriteLine($"{fansV:F2}%");
            Console.WriteLine($"{fansG:F2}%");
            Console.WriteLine($"{fansTotal:F2}%");
        }
    }
}
