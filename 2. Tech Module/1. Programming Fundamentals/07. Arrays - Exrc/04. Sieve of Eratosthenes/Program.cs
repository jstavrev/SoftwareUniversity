using System;
using System.Numerics;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1];
            long[] nums = new long[n + 1];
            int value = 0;
            for (int i = 0; i <= n; i++)
            {
                nums[i] = value;
                value++;
            }

            for (long i = 2; i <= n; i++)
            {
                primes[i] = true;
            }

            for (long p = 0; p <= n; p++)
            {
                if (primes[p] == true)
                {
                    for (long j = 2; j <= n; j++)
                    {
                        if (nums[p] * j <= n)
                        {
                            primes[j * p] = false;
                        }
                    }
                }
            }
            for (long i = 0; i <= n; i++)
            {
                if (primes[i] == true)
                {
                    Console.Write(nums[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
