using System;
using System.Linq;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int min = nums[0];
            int max = nums[0];
            int sum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                sum += nums[i];
            }
            double avrg = (double)sum / nums.Length;

            Console.WriteLine("Min = {0}", min);
            Console.WriteLine("Max = {0}", max);
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Average = {0}", avrg);
        }
    }
}