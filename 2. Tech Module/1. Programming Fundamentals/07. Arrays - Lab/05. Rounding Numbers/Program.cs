using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numsArr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < numsArr.Length; i++)
            {
                Console.WriteLine("{0} => {1}", numsArr[i], Math.Round(numsArr[i], MidpointRounding.AwayFromZero));
            }
        }
    }
}
