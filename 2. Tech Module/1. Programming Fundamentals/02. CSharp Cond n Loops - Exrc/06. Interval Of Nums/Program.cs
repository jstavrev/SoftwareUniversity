using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Interval_of_Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());

            if (n1 > n)

            {
                for (int i = n; i <= n1; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = n1; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}