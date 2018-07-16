using System;

namespace _04._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] jaggedArray = new long[n][];
            int size = 1;
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = new long[size];
                size++;
            }            
            for (int i = 0; i < n; i++)
            {
                jaggedArray[i][0] = 1;
            }
            for (int i = 0; i < n; i++)
            {
                jaggedArray[i][jaggedArray[i].Length - 1] = 1;
            }
            for (int i = 2; i < n; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    jaggedArray[i][j] = jaggedArray[i - 1][j - 1] + jaggedArray[i - 1][j];
                }                
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (j == jaggedArray[i].Length - 1)
                    {
                        Console.Write(jaggedArray[i][j]);
                        break;
                    }
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
