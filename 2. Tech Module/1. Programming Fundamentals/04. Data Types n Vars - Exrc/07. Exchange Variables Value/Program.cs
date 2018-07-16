using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Exchange_Variables_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int x = b;
            b = a;
            a = x;

            Console.WriteLine("Before:");
            Console.WriteLine("a = 5");
            Console.WriteLine("b = 10");
            Console.WriteLine("After:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
        }
    }
}
