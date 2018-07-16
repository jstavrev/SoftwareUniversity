using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reverse_Array_of_Int
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrNums = new int[n];

            for (int i = 0; i < n; i++)
            {
                int j = int.Parse(Console.ReadLine());
                arrNums[i] = j;
            }
            Array.Reverse(arrNums);
            Console.WriteLine(string.Join("\n", arrNums));
        }
    }
}
