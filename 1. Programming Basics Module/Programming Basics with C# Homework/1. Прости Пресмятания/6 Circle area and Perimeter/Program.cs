using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Circle_area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            //const float Pi = 3.14f;

            float r = float.Parse(Console.ReadLine());

            double area = Math.PI * r * r;
            double perimeter = 2 * Math.PI * r;

            Console.WriteLine("Area = {0}", area);
            Console.WriteLine("Perimeter = {0}", perimeter);
        }
    }
}
