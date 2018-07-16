using System;
using System.Linq;

namespace _02._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            FillMatrix(matrix);
            int result = CalcDiagonalDiff(matrix);
            Console.WriteLine(result);

        }

        private static int CalcDiagonalDiff(int[,] matrix)
        {
            int diagonalLeft = 0;
            int diagonalRight = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                diagonalLeft += matrix[i, i];
            }

            int counter = 0;
            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                diagonalRight += matrix[counter, i];
                counter++;
            }

            int result = Math.Abs(diagonalLeft - diagonalRight);
            return result;
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
