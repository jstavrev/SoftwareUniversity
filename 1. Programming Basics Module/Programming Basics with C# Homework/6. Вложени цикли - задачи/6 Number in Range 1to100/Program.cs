using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Number_in_Range_1to100
{
    class Program
    {
        static void Main(string[] args)
        {
         while (true)
            {
                Console.Write("Enter a number in the range [1...100]: ");
                int n = int.Parse(Console.ReadLine());

                if (n >= 1 && n <= 100)
                {
                    Console.WriteLine("The number is: {0}", n);
                    break;
                }
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
