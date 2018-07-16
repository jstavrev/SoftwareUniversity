using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());                

            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");

            for (int j = 0; j < n - 2; j++)
            {
                Console.Write("| ");
                for (int y = 0; y < n - 2; y++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("|");
            }

            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");

        }
    }
}
