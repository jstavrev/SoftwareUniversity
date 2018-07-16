using System;
using System.Linq;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sum = 0;

            for (int i = 0; ; i++)
            {
                if (i + nums[i] > nums.Length - 1 && i - nums[i] < 0)
                {
                    sum += nums[i];
                    break;
                }
                if (i + nums[i] > nums.Length - 1)
                {
                    sum += nums[i];
                    i -= nums[i] + 1;
                    continue;
                }
                sum += nums[i];
                i += nums[i] - 1;
            }
            Console.WriteLine(sum);
        }
    }
}