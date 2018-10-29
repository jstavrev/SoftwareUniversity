using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sort_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            input.Sort();

            Console.WriteLine(String.Join(" ", input));
        }
    }
}
