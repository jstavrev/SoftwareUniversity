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

            for (int i = 1; i <= 9; i++)
            {
                for (int y = 1; y <= 9; y++)
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        for (int k = 1; k <= 9; k++)
                        {
                            if (i + y == j + k && n % (i + y) == 0)
                                Console.Write($"{i}{y}{j}{k} ");
                        }
                    }
                }
            }
        }
    }
}
