using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            
            int rows = matrixSize[0];
            int cols = matrixSize[1];
            int sum = 0;
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                List<int> input = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = input[j];
                    sum += input[j];
                }
            }
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
