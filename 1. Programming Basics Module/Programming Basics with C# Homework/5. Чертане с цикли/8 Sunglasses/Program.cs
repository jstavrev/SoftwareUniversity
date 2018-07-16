using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string zvezda = new string('*', n * 2);
            string spacing = new string(' ', n);

            Console.Write(zvezda);
            Console.Write(spacing);
            Console.WriteLine(zvezda);

            for (int i = 0; i < n - 2; i ++)
            {
                Console.Write("*");
                Console.Write(new string('/', ((n * 5) - (n + 4)) / 2));
                Console.Write("*");
                if (i == (n - 1) / 2 - 1)
                {
                    Console.Write(new string('|', n));
                    Console.Write("*");
                    Console.Write(new string('/', ((n * 5) - (n + 4)) / 2));
                    Console.Write("*");
                }
                else
                {
                    Console.Write(spacing);
                    Console.Write("*");
                    Console.Write(new string('/', ((n * 5) - (n + 4)) / 2));
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.Write(zvezda);
            Console.Write(spacing);
            Console.WriteLine(zvezda);

        }
    }
}
