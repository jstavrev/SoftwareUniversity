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
            // Височина = 2 * n + 4;
            // Широчина = 5 * n;

            int asteriks = n * 3;
            int dots = n;
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('.', dots),
                    new string('#', asteriks));
                asteriks -= 2;
                dots++;
            }
            int midDots = n * 2 - 2;
            for (int i = 1; i <= n / 2 + 1; i++)
            {
                Console.WriteLine("{0}#{1}#{0}",
                    new string('.', (5* n - 2 - midDots) / 2),
                    new string('.', midDots));
                midDots -= 2;
            }
            Console.WriteLine("{0}{1}{0}",
                new string('.', n * 2),
                new string('#', n));
            PrintNAmountAsteriksRows(n);
            PrintDance(n);
            PrintN1AmountAsteriksRows(n);

        }

        private static void PrintNAmountAsteriksRows(int n)
        {
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                new string('.', (n * 5 - (n + 4)) / 2),
                new string('#', n + 4));
            }
        }

        private static void PrintDance(int n)
        {
            Console.WriteLine("{0}D^A^N^C^E^{0}",
                new string('.', (n * 5 - 10) / 2));
        }

        private static void PrintN1AmountAsteriksRows(int n)
        {
            for (int i = 1; i <= n / 2 + 1; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                new string('.', (n * 5 - (n + 4)) / 2),
                new string('#', n + 4));
            }
        }
    }
}
