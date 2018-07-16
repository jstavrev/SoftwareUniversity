using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Широчина и Височина == 2 * n + 1;

            PrintTopBottom(n);
            Console.WriteLine(".*{0}*.",
                new string(' ', n * 2 + 1 - 4));
            int dots = 2;
            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', dots),
                    new string('@', (2 * n + 1) - (dots * 2 + 2)));
                dots++;
            }
            PrintMidPart(n);
            int spacing = 0;
            int dotsBot = n - 1;
            for (int i = 0; i < n - 2; i ++)
            {
                Console.WriteLine("{0}*{1}@{1}*{0}",
                    new string('.', dotsBot),
                    new string(' ', spacing));
                spacing++;
                dotsBot--;

            }
            Console.WriteLine(".*{0}*.",
                new string('@', n * 2 - 3));
            PrintTopBottom(n);
        }

        private static void PrintMidPart(int n)
        {
            Console.WriteLine("{0}*@*{0}",
                new string('.', (2 * n + 1 - 3) / 2));
            Console.WriteLine("{0}*{0}",
                new string('.', n));
        }

        private static void PrintTopBottom(int n)
        {
            Console.WriteLine("{0}",
                new string('*', 2 * n + 1));
        }
    }
}
