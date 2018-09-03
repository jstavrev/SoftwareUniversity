using System;

namespace _03._Recursive_Drawing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Print(n);
        }

        public static void Print(int n)
        {
            if (n == 0)
            {
                return;
            }

            Console.WriteLine("{0}",
                new string('*', n));

            Print(n - 1);

            Console.WriteLine("{0}",
                new string('#', n));
        }
    }
}
