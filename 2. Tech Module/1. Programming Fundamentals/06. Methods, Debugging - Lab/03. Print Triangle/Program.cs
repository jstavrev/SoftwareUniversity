using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Print_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintNumTriangle(n);
        }

        static void PrintNumTriangle(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int y = 1; y <= i; y++)
                {
                    Console.Write(y + " ");
                }
                Console.WriteLine();
            }
            for (int i = num - 1; i > 0; i--)
            {
                for (int y = 1; y <= i; y++)
                {
                    Console.Write(y + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
