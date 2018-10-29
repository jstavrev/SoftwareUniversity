using System;

namespace _04._Generating_Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int index = 0;

            Generate(arr, index);
        }

        public static void Generate(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                Console.WriteLine(String.Join("", arr));
                return;
            }

            for (int i = 0; i <= 1; i++)
            {
                arr[index] = i;
                Generate(arr, index + 1);
            }
        }
    }
}
