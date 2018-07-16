using System;
using System.Linq;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;
            int result = 0;
            bool check = false;

            if (nums.Length == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        leftSum += nums[j];
                    }
                    for (int y = i + 1; y < nums.Length; y++)
                    {
                        rightSum += nums[y];
                    }
                    if (leftSum == rightSum)
                    {
                        result = i;
                        check = true;
                        break;
                    }
                    leftSum = 0;
                    rightSum = 0;
                }
                if (check)
                {
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
}
