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
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double houseArea = ((x * x - 1.2 * 2) + (x * x)) + (((y * x) + (y * x)) - (1.5 * 1.5 + 1.5 * 1.5));
            double roofArea = (2 * (x * y)) + (2 * ((x * h) / 2));
            double greenPaint = houseArea / 3.4;
            double redPaint = roofArea / 4.3;
            Console.WriteLine($"{greenPaint:F2}");
            Console.WriteLine($"{redPaint:F2}");
        }
    }
}
