using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            bool floatChecker = false;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == ',')
                {
                    floatChecker = true;
                }
            }

            if (floatChecker)
            {
                Console.WriteLine("floating-point");
            }
            else
            {
                Console.WriteLine("integer");
            }
        }
    }
}
