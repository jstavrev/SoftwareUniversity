﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());

            if (speed <= 10)
            {
                Console.WriteLine("slow");
            }  
            if ( speed > 10 && speed <= 50 )
                {
                    Console.WriteLine("average");
                }
            if ( speed > 50 && speed <= 150)
                {
                    Console.WriteLine("fast");
                }
            if ( speed > 150 && speed <= 1000)
                {
                    Console.WriteLine("ultra fast");
                }
            if (speed > 1000)
            {
                Console.WriteLine("extremely fast");
            }
        }

    }
}
