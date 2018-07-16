using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int looper = 0;
            int sum = 0;

            for (int i = n; i > 0; i--)
            {
                for (int y = 1; y <= m; y++)
                {
                    sum += 3 * (i * y);
                    looper++;
                    if (sum >= maxSum)
                    {
                        break;
                    }

                }
                if (sum >= maxSum)
                {
                    break;
                }
            }
            if (sum >= maxSum)
            {
                Console.WriteLine($"{looper} combinations");
                Console.WriteLine($"Sum: {sum} >= {maxSum}");
            }
            else
            {
                Console.WriteLine($"{looper} combinations");
                Console.WriteLine($"Sum: {sum}");
            }

        }
    }
}