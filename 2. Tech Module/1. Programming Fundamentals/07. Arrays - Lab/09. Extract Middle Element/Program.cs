using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Extract_Middle_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            char bracket = '{';
            char bracketEnd = '}';

            if (arrNums.Length == 1) //one
            {
                Console.WriteLine($"{bracket}{arrNums[0]}{bracketEnd}");
            }
            else if (arrNums.Length % 2 == 0) //even
            {
                int y = arrNums.Length / 2;
                Console.Write($"{bracket} ");
                for (int i = arrNums.Length / 2; i < y + 2; i++)
                {
                    if (i == y + 2)
                    {
                        Console.Write($"{arrNums[i - 1]} ");
                        break;
                    }
                    Console.Write($"{arrNums[i - 1]}, ");
                }
                Console.WriteLine($"{bracketEnd}");
            }
            else if (arrNums.Length % 2 != 0) //odd
            {
                int y = arrNums.Length / 2;
                Console.Write($"{bracket} ");
                for (int i = arrNums.Length / 2; i <= y + 2; i++)
                {
                    if (i == y + 2)
                    {
                        Console.Write($"{arrNums[i - 1]} ");
                        break;
                    }
                    Console.Write($"{arrNums[i - 1]}, ");
                }
                Console.WriteLine($"{bracketEnd}");
            }
        }
    }
}
