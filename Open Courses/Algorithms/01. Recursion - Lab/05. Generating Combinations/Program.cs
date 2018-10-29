using System;
using System.Linq;

namespace _05._Generating_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] set = new int[n];
            int counter = 0;
            int border = 0;

            GenerateCombinations(arr, border, counter, set);
        }

        private static void GenerateCombinations(int[] arr, int border, int counter, int[] set)
        {
           if (counter >= set.Length)
            {
                Console.WriteLine(String.Join(" ", set));
                return;
            }
           else
            {
                for (int i = border; i < arr.Length; i++)
                {
                    set[counter] = arr[i];
                    GenerateCombinations(arr, i + 1, counter + 1, set);
                }
            }
        }
    }
}
