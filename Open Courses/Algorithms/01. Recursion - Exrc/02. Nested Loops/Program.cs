using System;

namespace _02._Nested_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            int index = 0;

            Solve(array, index);
        }

        private static void Solve(int[] array, int index)
        {
            if (index == array.Length)
            {
                Console.WriteLine(String.Join(" ", array));
                return;
            }

            for (int i = 1; i <= array.Length; i++)
            {
                array[index] = i;
                Solve(array, index + 1);
            }
        }
    }
}
