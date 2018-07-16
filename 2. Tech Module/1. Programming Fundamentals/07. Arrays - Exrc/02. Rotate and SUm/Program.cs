using System;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] numsRight = new int[nums.Length];
            int[] sum = new int[nums.Length];
            for (int i = 0; i < k; i++)
            {
                for (int y = 0; y < nums.Length; y++)
                {
                    numsRight[y] = nums[y];
                }
                int lastElement = nums.Last();
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    nums[j + 1] = numsRight[j];
                }
                nums[0] = lastElement;
                for (int s = 0; s < nums.Length; s++)
                {
                    sum[s] += nums[s];
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(sum[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
