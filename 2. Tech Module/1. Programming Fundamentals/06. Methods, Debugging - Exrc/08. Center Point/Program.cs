using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            FindClosestPointToCenter(x, y, x1, y1);
        }

        static void FindClosestPointToCenter(double x, double y, double x1, double y1)
        {
            double a = Math.Abs(x);
            double b = Math.Abs(y);
            double c = Math.Abs(x1);
            double d = Math.Abs(y1);

            double point = Math.Max(a, b);
            double point1 = Math.Max(c, d);

            if (point < point1)
            {
                Console.WriteLine("({0}, {1})", x, y);
            }
            else
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
        }
    }
}
