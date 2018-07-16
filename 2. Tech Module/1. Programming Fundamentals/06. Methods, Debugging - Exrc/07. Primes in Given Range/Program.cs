using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            FindPrimesInRange(n, m);
            Console.WriteLine();
        }

        static void FindPrimesInRange(int n, int m)
        {
            int[] arr = new int[m];
            int looper = 0;
            bool isPrime = false;
            for (int i = n; i <= m; i++)
            {
                for (int y = 2; y <= i; y++)
                {
                    if (i != y && i % y == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    isPrime = true;
                }
                if (isPrime)
                {
                    arr[looper] = i;
                    looper++;
                }
            }
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (arr[i] > 0 && arr[i+1] != 0)
                {
                    Console.Write($"{arr[i]}, ");
                }
                else if (arr[i] != 0)
                {
                    Console.Write(arr[i]);
                    break;
                }
            }
        }
    }
}
