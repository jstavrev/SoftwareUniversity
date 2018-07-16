using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Equal_pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int looper = 0;
            int sum = 0;
            int prevSum = 0;
            int maxDiff = 0;
            int diff = 0;

            while (looper < n)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                sum = num1 + num2;

                if (sum != prevSum && looper != 0)
                {
                    diff = Math.Abs(sum - prevSum);
                }
                if (diff > maxDiff)
                {
                    maxDiff = diff;
                }

                prevSum = sum;
                looper++;
            }
            if (maxDiff == 0)
            {
                Console.WriteLine("Yes, value={0}",sum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}",maxDiff);
            }                                 
        }
    }
}
