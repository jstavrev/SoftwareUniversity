using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> bestLIS = new List<int>();
            List<int> currentLIS = new List<int>();
            int n = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                n = i;
                currentLIS.Add(nums[i]);
                for (int y = n + 1; y < nums.Count; y++)
                {
                    if (nums[n] < nums[y])
                    {
                        currentLIS.Add(nums[y]);
                        n = y;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (currentLIS.Count > bestLIS.Count)
                {
                    bestLIS.Clear();
                    bestLIS.AddRange(currentLIS);
                    currentLIS.Clear();
                    continue;
                }
                currentLIS.Clear();
            }
            Console.WriteLine(String.Join(" ", bestLIS));
        }
    }
}
