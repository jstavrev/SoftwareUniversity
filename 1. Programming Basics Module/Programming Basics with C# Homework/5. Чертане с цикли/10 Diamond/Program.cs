using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("*");
            }
            else if (n == 2)
            {
                Console.WriteLine("**");
            }
            else
            {
              if (n % 2 == 0)
                {                
                    for (int i = 0; i < n / 2; i++)
                    {
                        int topMid = i * 2;

                        Console.WriteLine("{0}*{1}*{0}",
                           new string('-', (n - 2) / 2 - i),
                           new string('-', topMid));
                    }

                    int botLeftRight = 1;                   
                    for (int i = 1; i < n / 2; i++)
                    {
                        int botMid = n - 2 - 2 * botLeftRight;

                        Console.WriteLine("{0}*{1}*{0}",
                           new string('-', botLeftRight),
                           new string('-', botMid));
                        botLeftRight++;
                    }
                }
                else
                {
                    Console.WriteLine("{0}*{0}",
                        new string('-', n / 2));

                    int topMid = 1;
                    for (int i = 1; i <= n / 2; i++)
                    {
                        Console.WriteLine("{0}*{1}*{0}",
                            new string('-', (n - 2 - topMid) / 2),
                            new string('-',topMid));
                        topMid += 2;
                    }

                   int botMid = n - 4;
                   for (int i = 1; i < n / 2; i++)
                    {
                        Console.WriteLine("{0}*{1}*{0}",
                            new string('-', i),
                            new string('-', botMid));

                        botMid -= 2;
                    }
                    Console.WriteLine("{0}*{0}",
                         new string('-', n / 2));
                }            
            }
        }
    }
}
