using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());

            double nPow = CalcPow(n, pow);
            Console.WriteLine(nPow);
            
        }

        static double CalcPow(double n, double pow)
        {
            double sum = 1;           

            for (int i = 1; i <= pow; i++)
            {
                sum = sum * n;
            }
            return sum;
        }
    }
}
