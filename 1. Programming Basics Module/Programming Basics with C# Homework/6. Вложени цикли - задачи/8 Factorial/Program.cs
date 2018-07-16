using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            int factorial = 1;
            while (num <= n)
            {
                factorial = factorial * num;
                num++;
            }
            Console.WriteLine(factorial);
        }
    }
}
