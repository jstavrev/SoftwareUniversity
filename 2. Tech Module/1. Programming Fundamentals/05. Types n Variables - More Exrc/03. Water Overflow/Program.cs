﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxWater = 255;
            int pouredWater = 0;
            for (int i = 0; i < n; i++)
            {
                int water = int.Parse(Console.ReadLine());
                if (maxWater >= water)
                {
                    if (pouredWater + water > maxWater)
                    {
                        Console.WriteLine("Insufficient capacity!");
                    }
                    else
                    {
                        pouredWater += water;
                    }
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(pouredWater);
        }
    }
}
