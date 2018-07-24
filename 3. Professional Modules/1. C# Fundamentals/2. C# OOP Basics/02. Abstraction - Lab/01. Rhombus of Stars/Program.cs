using System;

namespace _01._Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PrintRow(n, i);
            }
            for (int i = n - 1; i >= 1; i--)
            {
                PrintRow(n, i);
            }
        }

        private static void PrintRow(int n, int row)
        {
            for (int i = 1; i <= n - row; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < row; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
