using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            for (int i = 0; i < nums.Count; i++)
            {
                if (i == nums.Count - 1)
                {
                    break;
                }
                if (nums[i] == nums[i + 1])
                {
                    nums[i] += nums[i + 1];
                    nums.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
