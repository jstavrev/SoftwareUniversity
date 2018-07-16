using System;
using System.Linq;

namespace _04._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int row = input[0];
            int column = input[1];
            int[,] matrix = new int[row, column];
            FillMatrix(matrix);
            FindSquare(matrix, row, column);
        }

        private static void FindSquare(int[,] matrix, int row, int column)
        {
            int sum = 0;
            int bestSum = int.MinValue;
            int startRow = 0;
            int startCol = 0;

            for (int i = 0; i < row - 2; i++)
            {
                for (int j = 0; j < column - 2; j++)
                {
                    sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        startRow = i;
                        startCol = j;
                    }
                }
            }
            Console.WriteLine($"Sum = {bestSum}");
            PrintSquare(matrix, startRow, startCol);
        }

        private static void PrintSquare(int[,] matrix, int startRow, int startCol)
        {
            for (int i = startRow; i < startRow + 3; i++)
            {
                for (int j = startCol; j < startCol + 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
        }
    }
}
