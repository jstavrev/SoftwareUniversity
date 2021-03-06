﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).Where(x => x % 2 == 0).ToList();
            int avrg = (int)input.Average();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] > avrg)
                    input[i]++;
                else if (input[i] <= avrg)
                    input[i]--;
            }
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
