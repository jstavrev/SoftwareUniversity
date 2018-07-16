using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            GetMax(a, b, c);
        }

        static void GetMax(int a, int b, int c)
        {
            int max = Math.Max(a, b);
            int totalMax = Math.Max(max, c);

            Console.WriteLine(totalMax);
        }
    }
}
