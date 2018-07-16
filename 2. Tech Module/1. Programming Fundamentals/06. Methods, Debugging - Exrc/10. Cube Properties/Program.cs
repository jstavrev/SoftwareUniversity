using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            switch (parameter)
            {
                case "face":
                    GetFace(side);
                    break;
                case "space":
                    GetSpace(side);
                    break;
                case "volume":
                    GetVolume(side);
                    break;
                case "area":
                    GetArea(side);
                    break;
            }
        }

        static void GetArea(double side)
        {
            double area = 6 * (side * side);
            Console.WriteLine($"{area:F2}");
        }

        static void GetVolume(double side)
        {
            double volume = Math.Pow(side, 3);
            Console.WriteLine($"{volume:F2}");
        }

        static void GetSpace(double side)
        {
            double space = Math.Sqrt(3 * (side * side));
            Console.WriteLine($"{space:F2}");
        }

        static void GetFace(double side)
        {
            double face = Math.Sqrt(2 * (side * side));
            Console.WriteLine($"{face:F2}");
        }
    }
}
