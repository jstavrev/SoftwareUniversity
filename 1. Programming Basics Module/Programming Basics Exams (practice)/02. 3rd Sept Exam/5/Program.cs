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

            int dotsTop = 0;
            int dotsTopMid = n;
            for (int i = 1; i <= n; i++)
            {
                if (i == n)
                {
                    Console.WriteLine("{0}*****{0}",
                        new string ('.', (2 * n + 3 - 5) / 2 ));
                    break;
                }
                Console.WriteLine("{0}*{1}*{1}*{0}",
                    new string('.', dotsTop),
                    new string('.',dotsTopMid));
                dotsTopMid--;
                dotsTop++;
            }
            PrintAsteriks(n);
            int dotsBot = n - 1;
            int dotsBotMid = 2;
            for (int i = n; i >= 1; i--)
            {
                if (i == n)
                {
                    Console.WriteLine("{0}*****{0}",
                        new string('.', (2 * n + 3 - 5) / 2));
                    dotsBot--;
                }
                else
                {
                    Console.WriteLine("{0}*{1}*{1}*{0}",
                    new string('.', dotsBot),
                    new string('.', dotsBotMid));
                    dotsBot--;
                    dotsBotMid++;
                }
            }
        }

        private static void PrintAsteriks(int n)
        {
            Console.WriteLine("{0}",
                new string('*', 2 * n + 3));
        }
    }
}
