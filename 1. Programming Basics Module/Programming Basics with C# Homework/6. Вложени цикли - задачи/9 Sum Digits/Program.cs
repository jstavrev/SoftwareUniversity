using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            int n = int.Parse(num);
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum = sum + n % 10;
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
