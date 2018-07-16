using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int spaceMiddleTop = n - 2;

            for (int i = 0; i < n / 2; i++)
            {
                int spaceLeftTop = i;

                Console.WriteLine("{0}x{1}x",
                    new string(' ', spaceLeftTop),
                    new string(' ', spaceMiddleTop));
                spaceMiddleTop -= 2;
            }
            Console.WriteLine("{0}x",
                new string(' ', n / 2));
            int spaceLeftBot = (n - 2) / 2;
            int spaceMiddleBot = 1;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}x{1}x",
                    new string(' ', spaceLeftBot),
                    new string(' ', spaceMiddleBot));
                spaceMiddleBot += 2;
                spaceLeftBot--;
            }
        }
    }
}