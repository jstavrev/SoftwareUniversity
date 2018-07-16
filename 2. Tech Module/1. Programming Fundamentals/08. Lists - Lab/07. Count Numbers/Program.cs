using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> distinctNums = new List<int>();
            int counter = 0;
            int checker = 0;
            bool breaker = false;
            List<int> occurrencesCounter = new List<int>(nums.Count);
            nums.Sort();
            for (int i = 0; i < nums.Count; i++)
            {
                if (i != 0)
                {
                    for (int y = i; y < nums.Count; y++)
                    {
                        for (int j = 0; j < distinctNums.Count; j++)
                        {
                            if (nums[y] == distinctNums[j])
                            {
                                breaker = true;
                                break;
                            }
                        }
                        if (breaker)
                        {
                            break;
                        }
                    }
                }               
                if (breaker)
                {
                    breaker = false;
                    continue;
                }
                checker = nums[i];
                for (int y = 0; y < nums.Count; y++)
                {
                    if (checker == nums[y])
                    {
                        counter++;
                    }
                }
                occurrencesCounter.Add(counter);
                distinctNums.Add(nums[i]);
                counter = 0;
            }
            for (int i = 0; i < distinctNums.Count; i++)
            {
                Console.WriteLine($"{distinctNums[i]} -> {occurrencesCounter[i]}");
            }
        }
    }
}
