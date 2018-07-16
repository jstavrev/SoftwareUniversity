using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co6_Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                string space = new string(' ', n - row);
                Console.Write(space);
                for (int col = 1; col <= row ; col++)
                {                  
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            for (int row = n - 1; row > 0; row--)
            {
                string space = new string(' ', n - row);
                Console.Write(space);
                for (int col = 0; col < row; col++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }



        }
    }
}
