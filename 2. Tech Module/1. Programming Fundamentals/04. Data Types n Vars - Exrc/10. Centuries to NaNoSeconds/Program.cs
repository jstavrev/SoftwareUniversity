﻿using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            BigInteger seconds = (BigInteger)minutes * 60;
            BigInteger milliseconds = seconds * 1000;
            BigInteger microseconds = milliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);
        }
    }
}
