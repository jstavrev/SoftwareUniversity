using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Condense_Arr_to_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            while (arrNums.Length > 1)
            {
                int[] condensed = new int[arrNums.Length - 1];
                for (int i = 0; i < arrNums.Length - 1; i++)
                {
                    condensed[i] = arrNums[i] + arrNums[i + 1];
                }
                arrNums = condensed;
            }           
            Console.WriteLine(arrNums[0]);
        }
    }
}
