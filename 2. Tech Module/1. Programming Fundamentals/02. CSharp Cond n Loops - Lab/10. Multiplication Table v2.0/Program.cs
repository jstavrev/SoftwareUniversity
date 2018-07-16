using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Multriplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplier = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());

            if (times <= 10)
            {
                for (int looper = times; looper <= 10; looper++)
                {
                    Console.WriteLine($"{multiplier} X {looper} = {multiplier * looper}");
                }
            }
            else
            {
                Console.WriteLine($"{multiplier} X {times} = {multiplier * times}");
            }
        }
    }
}