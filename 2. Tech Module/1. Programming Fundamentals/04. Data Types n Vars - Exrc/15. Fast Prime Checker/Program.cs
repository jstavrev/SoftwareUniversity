using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                bool TowaLIE = true;
                for (int y = 2; y <= Math.Sqrt(i); y++)
                {
                    if (i % y == 0)
                    {
                        TowaLIE = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {TowaLIE}");
            }

        }
    }
}
