using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_A_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSquareTopBottom(n);
            PrintSquareBody(n);
            PrintSquareTopBottom(n);
        }

        static void PrintSquareBody(int num)
        {
            for (int i = 0; i < num - 2; i++)
            {
                Console.Write("-");
                for (int y = 0; y < (num * 2 - 2) / 2; y++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }

        static void PrintSquareTopBottom(int num)
        {
            Console.WriteLine("{0}", new string('-', num * 2));
        }
    }
}
