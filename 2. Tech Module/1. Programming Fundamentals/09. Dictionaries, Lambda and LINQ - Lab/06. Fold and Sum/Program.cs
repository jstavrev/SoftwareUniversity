using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = input.Length / 4;
            int[] left = input.Take(k).Reverse().ToArray();
            int[] right = input.Reverse().Take(k).ToArray();
            int[] middle = input.Skip(k).Take(2 * k).ToArray();
            for (int i = 0; i < left.Length; i++)
            {
                middle[i] += left[i];
            }
            for (int i = 0; i < right.Length; i++)
            {
                middle[i + k] += right[i];
            }
            Console.WriteLine(String.Join(" ", middle));

        }
    }
}
