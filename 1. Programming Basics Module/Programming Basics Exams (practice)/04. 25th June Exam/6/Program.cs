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

            int counter = 0;

            for (int i = 1; i <= 30; i++)
            {
                for (int y = 1; y <= 30; y++)
                {
                    for (int j = 1; j <= 30; j++)
                    {
                        if (i < y && y < j && (i + y + j == n))
                        {
                            Console.WriteLine($"{i} + {y} + {j} = {i + y + j}");
                            counter++;
                        }
                        else if (i > y && y > j && i * y * j == n)
                        {
                            Console.WriteLine($"{i} * {y} * {j} = {i * y * j}");
                            counter++;
                        }
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
