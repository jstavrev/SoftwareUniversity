using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = matrixSize[0];
            int cols = matrixSize[1];
            int[,] matrix = new int[rows, cols];

            int sum = 0;
            int bestSum = int.MinValue;
            List<int> nums = new List<int>(4);

            for (int i = 0; i < rows; i++)
            {
                List<int> input = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        nums.Clear();
                        nums.Add(matrix[i, j]);
                        nums.Add(matrix[i, j + 1]);
                        nums.Add(matrix[i + 1, j]);
                        nums.Add(matrix[i + 1, j + 1]);
                    }
                }
            }
            Console.WriteLine(nums[0] + " " + nums[1]);
            Console.WriteLine(nums[2] + " " + nums[3]);
            Console.WriteLine(bestSum);
        }
    }
}
