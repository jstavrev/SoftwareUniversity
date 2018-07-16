using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> squareNums = new List<int>();
 
            for (int i = 0; i < nums.Count; i++)
            {
                if (Math.Sqrt(nums[i]) % 1 == 0)
                {
                    squareNums.Add(nums[i]);
                }
            }
            squareNums.Sort();
            squareNums.Reverse();
            Console.WriteLine(String.Join(" ", squareNums));

        }
    }
}
