using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            int password = 0;
            for (int a = 1; a < 10; a++)
            {
                for (int b = 1; b < 10; b++)
                {
                    for (int c = 1; c < 10; c++)
                    {
                        for (int d = 1; d < 10; d++)
                        {
                            if (n == a * b + c * d && a < b && c > d)
                            {
                                Console.Write($"{a}{b}{c}{d} ");
                                counter++;
                                if (counter == 4)
                                {
                                    password = a * 1000 + b * 100 + c * 10 + d;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            if (counter < 4)
            {
                Console.WriteLine("No!");
            }
            else
            {
                Console.WriteLine($"Password: {password}");
            }
        }
    }
}
