using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Sequance_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num = 1;

            do
            {
                Console.WriteLine(num);

                num = num * 2 + 1;
            } while (num <= n);


        }
    }
}
