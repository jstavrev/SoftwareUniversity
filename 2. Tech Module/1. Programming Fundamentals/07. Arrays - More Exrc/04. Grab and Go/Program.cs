using System;
using System.Linq;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int index = 0;
            long sum = 0;
            bool checker = true;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == n)
                {
                    checker = false;
                    index = i;
                }
            }
            if (checker)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                for (int i = 0; i < index; i++)
                {
                    sum += nums[i];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
