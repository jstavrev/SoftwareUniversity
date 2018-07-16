using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sentence_the_Thief
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

            double result = 0.0;
            if (maxValue < 0)
            {
                result = Math.Ceiling((double)maxValue / -128);
            }
            else 
            {
                result = Math.Ceiling((double)maxValue / 127);
            }

            if (result == 1)
            {
                Console.WriteLine($"Prisoner with id {maxValue} is sentenced to {result} year");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {maxValue} is sentenced to {result} years");
            }
        }
    }
}
