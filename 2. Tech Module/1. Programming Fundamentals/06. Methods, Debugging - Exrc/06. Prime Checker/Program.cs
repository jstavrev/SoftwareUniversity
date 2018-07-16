using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            IsPrime(n);
        }

        static void IsPrime(long n)
        {           
            bool isPrime = false;
            long nSquare = (long)Math.Sqrt(n);

            if (n < 2)
            {
                Console.WriteLine("False");
            }
            else
            {
                for (int i = 2; i <= nSquare + 1; i++)
                {
                    if (n != i && n % i == 0)
                    {
                        Console.WriteLine("False");
                        isPrime = false;
                        break;
                    }
                    isPrime = true;
                }
                if (isPrime)
                {
                    Console.WriteLine("True");
                }
            }
        }
    }
}
