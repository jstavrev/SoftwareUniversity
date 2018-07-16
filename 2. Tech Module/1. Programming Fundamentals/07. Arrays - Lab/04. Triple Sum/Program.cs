using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] stringArr = numbers.Split(' ');
            long[] numsArr = new long[stringArr.Length];
            bool no = true;

            for (int i = 0; i < stringArr.Length; i++)
            {
                numsArr[i] = Int32.Parse(stringArr[i]);
            }

            for (int i = 0; i < numsArr.Length; i++)
            {
                for (int y = i + 1; y < numsArr.Length; y++)
                {
                    for (int j = 0; j < numsArr.Length; j++)
                    {
                        if (numsArr[i] + numsArr[y] == numsArr[j])
                        {
                            no = false;
                            Console.WriteLine($"{numsArr[i]} + {numsArr[y]} == {numsArr[j]}");
                            break;
                        }
                    }
                }
            }
            if (no)
            {
                Console.WriteLine("No");
            }           
        }
    }
}
