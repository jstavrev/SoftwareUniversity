using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sum_of_Odd_Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int nCount = 1;

            for (int i = 1; i <= n * 2 - 1; i += 2)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}