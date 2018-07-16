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

            //Ширина = 3 * n;
            //Височина = 2 * n + 8;

            Console.WriteLine("{0}x{0}", new string('.', (3 * n - 1) / 2));
            Console.WriteLine("{0}/x\\{0}", new string('.', (3 * n - 3) / 2));
            Console.WriteLine("{0}x|x{0}", new string('.', (3 * n - 3) / 2));
            int counter = n;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}",
                    new string('.',((3 * n) - (counter * 2 + 1)) / 2),
                    new string('x',counter));
                counter++;
            }
            Console.WriteLine("{0}|{0}", new string('x',(3 * n - 1) / 2 ));
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}",
                    new string('.', i),
                    new string('x', (3 * n - (i * 2 + 1)) / 2));
                
            }
            Console.WriteLine("{0}/x\\{0}", new string('.', (n * 3 - 3) / 2));
            Console.WriteLine("{0}\\x/{0}", new string('.', (n * 3 - 3) / 2));
            int counter1 = n;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}",
                    new string('.', ((3 * n) - (counter1 * 2 + 1)) / 2),
                    new string('x', counter1));
                counter1++;
            }
            Console.WriteLine("{0}|{0}", new string('x', (3 * n - 1) / 2));
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}",
                    new string('.', i),
                    new string('x', (3 * n - (i * 2 + 1)) / 2));

            }
            Console.WriteLine("{0}x|x{0}", new string('.', (3 * n - 3) / 2));
            Console.WriteLine("{0}\\x/{0}", new string('.', (n * 3 - 3) / 2));
            Console.WriteLine("{0}x{0}", new string('.', (3 * n - 1) / 2));
        }
    }
}
