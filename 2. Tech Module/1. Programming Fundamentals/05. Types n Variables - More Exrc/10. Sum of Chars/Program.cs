﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                char chr = char.Parse(Console.ReadLine());

                sum += chr;
            }
            Console.WriteLine("The sum equals: {0} ", sum);
        }
    }
}
