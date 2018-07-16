using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            SortedDictionary<double, int> pairs = new SortedDictionary<double, int>();

            foreach (double item in input)
            {
                if (pairs.ContainsKey(item))
                {
                    pairs[item]++;
                }
                else
                {
                    //pairs[item] = 1;
                    pairs.Add(item, 1);
                }
            }

            foreach (var i in pairs)
            {
                Console.WriteLine($"{i.Key} -> {i.Value}");
            }
        }
    }
}
