using System;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = nums.Length / 4;
            int[] leftSide = new int[k];
            int[] rightSide = new int[k];
            int[] middle = new int[k * 2];
            int[] sum = new int[k * 2];

            for (int i = 0; i < k; i++)
            {
                leftSide[i] = nums[i];
            }
            Array.Reverse(leftSide);
            int right = 0;
            for (int i = nums.Length - 1; i >= nums.Length - k; i--)
            {
                rightSide[right] = nums[i];
                right++;
            }
            int[] combined = leftSide.Concat(rightSide).ToArray();
            int middleCounter = 0;
            for (int i = k; i < k * 3; i++)
            {
                middle[middleCounter] = nums[i];
                middleCounter++;
            }

            for (int i = 0; i < k * 2; i++)
            {
                sum[i] = combined[i] + middle[i];
            }

            for (int i = 0; i < k * 2; i++)
            {
                Console.Write(sum[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
