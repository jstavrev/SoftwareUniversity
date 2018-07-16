using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.Factorial_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = CalcFactorial(n);

            int counter = 0;
            while (true)
            {
                if (factorial % 10 == 0)
                {
                    counter++;
                }
                else
                {
                    break;
                }
                factorial = factorial / 10;
            }
            Console.WriteLine(counter);
        }

        private static BigInteger CalcFactorial(int n)
        {
            BigInteger f = 1;
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            return f;
        }
    }
}
