﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string dollar = new string('$', 1);

            for (int i = 0; i < n ; i ++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("{0} ", dollar);
                }
                Console.WriteLine();
            }
        }
    }
}
