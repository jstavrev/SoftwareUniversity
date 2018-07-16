using System;
using System.Linq;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int len = 0;
            int bestStart = 0;
            int bestlen = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length - 1)
                {
                    break;
                }
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        len++;
                    }
                }
                if (len > bestlen)
                {
                    bestlen = len;
                    bestStart = i;
                }
                len = 0;
            }
            Console.WriteLine(nums[bestStart]);
        }
    }
}
