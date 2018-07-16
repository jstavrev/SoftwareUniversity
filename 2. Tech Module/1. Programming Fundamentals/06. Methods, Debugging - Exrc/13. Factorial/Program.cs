﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = CalcFactorial(n);
            Console.WriteLine(factorial);
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
