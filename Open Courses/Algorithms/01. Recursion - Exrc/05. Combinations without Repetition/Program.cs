using System;

namespace _03._Combinations_with_Repetitions
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[k];

            int index = 0;
            Solve(array, index, n);
        }

        private static void Solve(int[] array, int index, int n, int element = 1)
        {
            if (index == array.Length)
            {
                if (CheckIfAllElementsAreEqual(array))
                    return;

                Console.WriteLine(String.Join(" ", array));

                return;
            }

            for (int i = element; i <= n; i++)
            {
                array[index] = i;

                Solve(array, index + 1, n, i);
            }
        }

        private static bool CheckIfAllElementsAreEqual(int[] array)
        {
            bool areEqual = false;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    areEqual = true;
                    break;
                }
            }

            return areEqual;
        }
    }
}
