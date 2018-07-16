using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Remove_Negatives_n_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            RemoveAllNegatives(nums);
            nums.Reverse();
            if (nums.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(String.Join(" ", nums));
            }
        }

        private static void RemoveAllNegatives(List<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] < 0)
                {
                    nums.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
