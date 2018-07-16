using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Nums_in_Reveresed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            PrintInReverse(n);

        }

        static void PrintInReverse(string n)
        {
            string[] reverse = new string[n.Length];

            int looper = 0;
            for (int i = n.Length - 1; i >= 0; i--)
            {
                char val = n[i];
                reverse[looper] = val.ToString();
                looper++;
            }
            for (int i = 0; i < reverse.Length; i++)
            {
                Console.Write(reverse[i]);
            }
            Console.WriteLine();
        }
    }
}
