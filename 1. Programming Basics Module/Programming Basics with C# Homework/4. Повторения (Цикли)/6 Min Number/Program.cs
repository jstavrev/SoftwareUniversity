using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            int min = int.Parse(Console.ReadLine());

            int currentMin = min;

            for (int i = 1; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers < currentMin)
                {
                    currentMin = numbers;
                }

            }
            Console.WriteLine(currentMin);
        }
    }
}
