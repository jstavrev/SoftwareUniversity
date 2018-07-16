using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sign_of_Int_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }

        static void PrintSign(int num)
        {
            if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        }
    }
}
