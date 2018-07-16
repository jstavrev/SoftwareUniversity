using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == arr[0])
                {
                   
                    if (i - arr[1] < 0)
                    {

                    }
                    else if (i + arr[1] > nums.Count - 1)
                    {

                    }
                    else
                    {
                        nums.RemoveRange(i - arr[1], arr[1] * 2 + 1);
                    }
                    i = 0;
                }                
            }
            Console.WriteLine(nums.Sum());
        }
    }
}
