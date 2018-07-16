using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            double side;
            double height;
            double width;
            double radius;

            switch (figureType)
            {
                case "triangle":
                    side = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());
                    GetTriangleArea(side, height);
                    break;
                case "square":
                    side = double.Parse(Console.ReadLine());
                    GetSquareArea(side);
                    break;
                case "rectangle":
                    width = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());
                    GetRectangleArea(width, height);
                    break;
                case "circle":
                    radius = double.Parse(Console.ReadLine());
                    GetCircleArea(radius);
                    break;
            }
        }

        private static void GetCircleArea(double radius)
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"{area:F2}");
        }

        private static void GetRectangleArea(double width, double height)
        {
            double area = width * height;
            Console.WriteLine($"{area:F2}");
        }

        private static void GetSquareArea(double side)
        {
            double area = side * side;
            Console.WriteLine($"{area:F2}");
        }

        private static void GetTriangleArea(double side, double height)
        {
            double area = side * height / 2;
            Console.WriteLine($"{area:F2}");
        }
    }
}
