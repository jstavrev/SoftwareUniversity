using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Max_Seq_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int start = 1;
            int len = 1;
            int bestStart = 0;
            int bestLen = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                start = i;
                len = 1;
                for (int y = i + 1; y < nums.Count; y++)
                {
                    if (nums[i] == nums[y])
                    {
                        len++;
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                if (len > bestLen)
                {
                    bestLen = len;
                    bestStart = start;
                }
            }
            for (int i = bestStart; i < bestStart + bestLen; i++)
            {
                if (i == bestStart + bestLen - 1)
                {
                    Console.WriteLine(nums[i]);
                    break;
                }
                Console.Write(nums[i] + " ");
            }
        }
    }
}
