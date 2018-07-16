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
            // Heigth = 4 * n + 4
            // Width = 3 * n + 1

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("+{0}+{1}",
                new string('~', n - 2),
                new string('.', (3 * n + 1) - n));
            for (int i = 0; i < (4 * n + 4) / 2 - 1; i++)
            {
                Console.WriteLine("|{0}\\{1}\\{2}",
                    new string('.', i),
                    new string('~', n - 2),
                    new string('.', (3 * n + 1) - ((n - 2) + i + 3)));
            }
            for (int i = 0; i < (4 * n + 4) / 2 - 1; i++)
            {
                Console.WriteLine("{0}\\{1}|{2}|",
                    new string('.', i),
                    new string('.', (3 * n + 1) - (n - 2 + i + 3)),
                    new string('~', n - 2));
            }
            Console.WriteLine("{1}+{0}+",
                new string('~', n - 2),
                new string('.', 3 * n + 1 - n));
        }
    }
}
