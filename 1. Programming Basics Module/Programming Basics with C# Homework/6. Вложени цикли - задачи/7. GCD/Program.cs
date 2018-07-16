using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int c = 0;

            while (a != 0)
            {
                c = a;
                a = b % a;
                b = c;
            }
            Console.WriteLine(b);
        }   
    }
}
