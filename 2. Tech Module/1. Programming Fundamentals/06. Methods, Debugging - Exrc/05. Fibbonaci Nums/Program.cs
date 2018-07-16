using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibbonaci_Nums
{
    class Program
    {
        static void Main(string[] args)
        {         
                int n = int.Parse(Console.ReadLine());
                FobonacciCalculator(n);
        }

        static void FobonacciCalculator(int n)
        {
            int f0 = 1;
            int f1 = 1;
            int looper = 1;
            int fSum = 0;
            if (n < 2)
            {
                Console.WriteLine(1);
            }
            else
            {
                while (looper < n)
                {
                    fSum = f0 + f1;
                    f0 = f1;
                    f1 = fSum;
                    looper++;
                }
                Console.WriteLine(fSum);
            }
        }
    }
}
