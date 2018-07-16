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
            //Width = 3 * n + 6
            //Heigth = 3 * n + 1

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}~ ~ ~{0}",
                    new string(' ', n));
            }
            PrintEquals(n);
            for (int i = 1; i <= n - 2; i++)
            {
                if (i == n / 2)
                {
                    Console.WriteLine("|{0}JAVA{0}|{1}|",
                        new string('~', n),
                        new string(' ', n - 1));
                    continue;
                }
                Console.WriteLine("|{0}|{1}|",
                    new string('~', n * 2 + 4),
                    new string(' ', n - 1));               
            }
            PrintEquals(n);
            int atSigns = 2 * n + 4;
            int space = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{1}\\{0}/",
                    new string('@', atSigns),
                    new string(' ', space));
                atSigns -= 2;
                space++;
            }
            Console.WriteLine("{0}",
                new string('=', 2 * n + 6));
        }

        private static void PrintEquals(int n)
        {
            Console.WriteLine("{0}",
                new string('=', 3 * n + 5));
        }
    }
}
