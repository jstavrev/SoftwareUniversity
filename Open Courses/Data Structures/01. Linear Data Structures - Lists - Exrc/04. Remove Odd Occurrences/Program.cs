using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Remove_Odd_Occurrences
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

            for (int i = 0; i < input.Count; i++)
            {
                if (dict[input[i]] % 2 != 0)
                {
                    input.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine(String.Join(" ", input));
        }
    }
}
