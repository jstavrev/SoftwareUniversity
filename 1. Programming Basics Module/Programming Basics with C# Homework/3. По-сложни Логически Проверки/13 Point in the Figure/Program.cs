using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int x1 = 0;
            int y1 = 0;

            int x2 = 3 * h;
            int y2 = h;

            int x3 = 2 * h;
            int y3 = h;

            int x4 = h;
            int y4 = 4 * h;


            bool insideSquare1 = x < x2 && x > x1 && y > y1 && y < y2;
            bool insideSquare2 = x > x4 && x < x3 && y > y3 && y < y4;
            bool insideBorder = y == y3 && x3 > x && x > x4;
            bool border1Square1 = (y1 <= y && y2 >= y) && (x1 == x || x2 == x);
            bool border2Square1 = (y1 == y || y2 == y) && (x1 <= x && x2 >= x);
            bool border1Square2 = (y3 <= y && y4 >= y) && (x3 == x || x4 == x);
            bool border2Square2 = (y3 == y || y4 == y) && (x4 <= x && x3 >= x);


            if (insideSquare1 || insideSquare2 || insideBorder)
            {
                Console.WriteLine("inside");
            }
            else if (border1Square1 || border2Square1 || border1Square2 || border2Square2)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
