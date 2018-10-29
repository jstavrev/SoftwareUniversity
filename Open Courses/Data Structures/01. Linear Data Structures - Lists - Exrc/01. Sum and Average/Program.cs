using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_and_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

                Console.WriteLine($"Sum={input.Sum()}; Average={input.Average():F2}");
            }
            catch
            {
                Console.WriteLine("Sum=0; Average=0.00");
            }
        }
    }
}
