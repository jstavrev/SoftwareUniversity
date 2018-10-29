using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_of_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            foreach (var num in input)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict[num] = 1;
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value} times");
            }
        }
    }
}
