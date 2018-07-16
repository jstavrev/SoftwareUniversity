using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Last_K_Num_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());


            long[] numsArr = new long[n];
            numsArr[0] = 1;

            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                long start = Math.Max(0, i - k);
                for (long y = start ; y <= i - 1 ; y++)
                {
                    sum += numsArr[y];
                }
                numsArr[i] += sum;
            }            
            Console.WriteLine(string.Join("\n", numsArr));
        }
    }
}
