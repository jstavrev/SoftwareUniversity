using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int controlNum = int.Parse(Console.ReadLine());

            int sum = 0;
            int moves = 0;
            for (int i = 1; i <= n; i++)
            {
                if (sum >= controlNum)
                {
                    break;
                }
                for (int j = m; j >= 1; j--)
                {
                    if (sum >= controlNum)
                    {
                        break;
                    }

                    sum += i * 2 + j * 3;
                    moves++;
                }
            }
            if (sum >= controlNum)
            {
                Console.WriteLine($"{moves} moves");
                Console.WriteLine($"Score: {sum} >= {controlNum}");
            }
            else
            {
                Console.WriteLine($"{moves} moves");
            }
        }
    }
}
