using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());

            double perimeter = (width + heigth) * 2;
            double area = width* heigth;
            double width2 = width * width;
            double heigth2 = heigth * heigth;
            double diagonal = Math.Sqrt(width2 + heigth2);
            

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
