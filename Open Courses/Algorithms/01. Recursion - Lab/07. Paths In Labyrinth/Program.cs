using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Paths_In_Labyrinth
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            char[,] labyrinth = new char[n, m];
            bool[,] visited = new bool[n, m];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                for (int y = 0; y < input.Length; y++)
                {
                    labyrinth[i, y] = input[y];
                }
            }

            int row = 0;
            int col = 0;

            string result = string.Empty;
            Solve(labyrinth, visited, row, col, result);
        }

        private static void Solve(char[,] labyrinth, bool[,] visited, int row, int col, string result)
        {
            if (row < 0 || col < 0 || row >= labyrinth.GetLength(0) || col >= labyrinth.GetLength(1))
            {
                return;
            }

            if (visited[row, col])
            {
                return;
            }

            if (labyrinth[row, col] == 'e')
            {
                Console.WriteLine(result);
                return;
            }

            if (labyrinth[row, col] == '*')
            {
                return;
            }

            visited[row, col] = true;

            Solve(labyrinth, visited, row, col + 1, result += 'R'); // right
            result = result.Remove(result.Length - 1);
            Solve(labyrinth, visited, row + 1, col, result += 'D'); // down
            result = result.Remove(result.Length - 1);
            Solve(labyrinth, visited, row, col - 1, result += 'L'); // left
            result = result.Remove(result.Length - 1);
            Solve(labyrinth, visited, row - 1, col, result += 'U'); // up
            result = result.Remove(result.Length - 1);

            visited[row, col] = false;
        }
    }
}
