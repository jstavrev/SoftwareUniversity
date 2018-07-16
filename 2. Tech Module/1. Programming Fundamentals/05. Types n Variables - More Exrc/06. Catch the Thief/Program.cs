using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            long max = 0;
            switch (type)
            {
                case "sbyte": max = sbyte.MaxValue; break;
                case "int": max = int.MaxValue; break;
                case "long": max = long.MaxValue; break;
            }
            long maxValue = -9223372036854775808;
            for (int i = 0; i < n; i++)
            {
                long num = long.Parse(Console.ReadLine());

                if (num <= max)
                {
                    if (num >= maxValue)
                    {
                        maxValue = num;
                    }
                }
            }
            Console.WriteLine(maxValue);
        }
    }
}
