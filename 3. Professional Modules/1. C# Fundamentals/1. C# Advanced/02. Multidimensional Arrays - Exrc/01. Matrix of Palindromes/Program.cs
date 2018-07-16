using System;
using System.Linq;

namespace _01._Matrix_of_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int row = input[0];
            int column = input[1];
            int[,] matrix = new int[row, column];
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int counter = 0;

            for (int i = 0; i < row; i++)
            {
                counter = i;
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{alphabet[i]}{alphabet[counter]}{alphabet[i]} ");
                    counter++;
                }
                Console.WriteLine();
            }

        }
    }
}
