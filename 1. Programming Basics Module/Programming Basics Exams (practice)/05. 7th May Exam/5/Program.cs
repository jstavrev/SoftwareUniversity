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
            // Width = (2 * n) - 1;
            // Heigth = (n / 2) + 4;
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("@{0}@{0}@",
                new string(' ', (2 * n - 4) / 2));
            Console.WriteLine("**{0}*{0}**",
                new string(' ',(2 * n - 6) / 2));
            int spacing = (2 * n - 10) /2;
            int dot = 1;
            for (int i = 1; i < n / 2 - 1; i++)
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*",
                    new string('.', i),
                    new string(' ', spacing),
                    new string('.', dot));
                spacing -= 2;
                dot += 2;
            }
            Console.WriteLine("*{0}*{1}*{0}*",
                new string('.', n / 2 - 1),
                new string('.', n - 3));
            Console.WriteLine("*{0}{1}.{1}{0}*",
                new string('.', n / 2),
                new string('*', (((2 * n) - 3) - n) / 2 ));
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0}",
                    new string('*', (2 * n) - 1));
            }
        }
    }
}
