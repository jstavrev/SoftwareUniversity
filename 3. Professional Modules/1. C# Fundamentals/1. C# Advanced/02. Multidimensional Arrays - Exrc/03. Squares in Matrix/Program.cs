using System;
using System.Linq;

namespace _03._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int row = input[0];
            int column = input[1];
            char[,] matrix = new char[row, column];
            FillMatrix(matrix);
            int squares = FindSquares(matrix, row, column);
            Console.WriteLine(squares);

        }

        private static int FindSquares(char[,] matrix, int row, int column)
        {
            int squares = 0;
            for (int i = 0; i < row - 1; i++)
            {
                for (int j = 0; j < column - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1] && matrix[i, j] == matrix[i + 1, j] && matrix[i,j] == matrix[i + 1, j + 1])
                    {
                        squares++;
                    }
                }
            }
            return squares;
        }

        private static void FillMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string input = Console.ReadLine();
                char[] charArr = input.Where(x => x != ' ').ToArray();
                for (int j = 0; j < charArr.Length; j++)
                {
                    matrix[i, j] = charArr[j];
                }
            }
        }
    }
}
