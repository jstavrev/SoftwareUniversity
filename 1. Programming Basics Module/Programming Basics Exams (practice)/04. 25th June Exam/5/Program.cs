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

            //Широчина = (4 * n) + 1;
            //Височина = (2 * н) + 1;
            int width = 4 * n + 1;
            Console.WriteLine("{0}", new string('#', 4 * n + 1));
            int hashtag = 4 * n + 1;
            int spacing = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i == n / 2 + 1)
                {
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("{0}{1}{2}(@){2}{1}{0}",
                            new string('.', i),
                            new string('#', n - 1),
                            new string(' ', n / 2 - 1));
                    }
                    else
                    {
                        Console.WriteLine("{0}{1}{2}(@){2}{1}{0}",
                            new string('.', i),
                            new string('#', n),
                            new string(' ', (width - (i * 2) - (n * 2) - 3) / 2));
                    }
                    spacing += 2;
                    continue;
                }

                Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string('.', i),
                    new string('#', (hashtag - 2 * i - spacing) / 2),
                    new string(' ', spacing));
                spacing += 2;

            }

            int hashtagBot = n * 2 - 1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('.', (width - hashtagBot) / 2),
                    new string('#', hashtagBot));

                hashtagBot -= 2;
            }
        }
    }
}
