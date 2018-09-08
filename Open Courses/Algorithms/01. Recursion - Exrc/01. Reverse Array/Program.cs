using System;

namespace _01._Reverse_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            var result = new string[arr.Length];

            int index = arr.Length;
            ReverseArray(arr, result, index);

            Console.WriteLine(String.Join(" ", result));
        }

        public static void ReverseArray(string[] arr, string[] result, int index)
        {
            if (index < 0)
            {
                return;
            }

            ReverseArray(arr, result, index - 1);

            if (index == arr.Length)
            {
                return;
            }

            result[index] = arr[arr.Length - (index + 1)];
        }
    }
}
