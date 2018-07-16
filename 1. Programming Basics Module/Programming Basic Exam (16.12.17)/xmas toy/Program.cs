using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xmas_toy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Shirina = 5 * n;
            //Visochina = 2 * n +3;

            PrintTopBottomPart(n);
            int asteriks = 1;
            int midSign = n + 2;
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                   new string('-', (5 * n - asteriks * 2 - midSign) / 2),
                   new string('*', asteriks),
                   new string('&', midSign));
                asteriks++;
                midSign += 2;
            }
            int linesTop = n - 1;
            int console = 3 * n - 2;
            for (int i = 1; i <= n / 2; i ++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                   new string('-', linesTop),
                   new string('*', 2),
                   new string('~', console));
                asteriks++;
                console += 2;
                linesTop--;
            }
            PrintMidLine(n);
            int line = n / 2;
            for (int i = n / 2; i >= 1; i --)
            {
                Console.WriteLine("{0}**{1}**{0}",
                    new string('-', line),
                    new string('~', 5 * n - 4 - line * 2));
                line++;
            }
            int sign = 2 * n;
            int asteriksBot = n / 2;
            for (int i = n / 2; i >= 1; i--)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string('-', (5 * n - asteriksBot * 2 - sign) / 2),
                    new string('*', asteriksBot),
                    new string('&', sign));
                sign -= 2;
                asteriksBot--;
            }
            PrintTopBottomPart(n);
        }

        private static void PrintMidLine(int n)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('-', n / 2),
                new string('|', 5 * n - n - 2));
        }

        private static void PrintTopBottomPart(int n)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('-', 2 * n),
                new string('*', n));
        }
    }
}
