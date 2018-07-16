using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = i;

                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine("{0} -> True", i);
                }
                else
                {
                    Console.WriteLine("{0} -> False", i);
                }
                sum = 0;
            }
        }
    }
}