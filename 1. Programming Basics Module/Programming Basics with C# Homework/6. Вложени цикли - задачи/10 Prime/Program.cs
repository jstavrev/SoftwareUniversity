using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isPrime = false;
            int nSquare = (int)Math.Sqrt(n);
            
            if (n < 2)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                for (int i = 2; i <= nSquare + 1; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine("Not Prime");
                        isPrime = false;
                        break;
                    }
                    isPrime = true;
                }
               if (isPrime)
                {
                    Console.WriteLine("Prime");
                }
            }
        }
    }
}
