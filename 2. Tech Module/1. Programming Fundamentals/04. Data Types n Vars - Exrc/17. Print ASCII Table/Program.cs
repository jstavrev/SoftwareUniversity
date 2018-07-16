using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            char start = Convert.ToChar(a);
            char end = Convert.ToChar(b);

            for (int i = start; i <= end; i++)
            {
                char chr = Convert.ToChar(i);
                Console.Write("{0} ", chr);
            }
        }
    }
}
