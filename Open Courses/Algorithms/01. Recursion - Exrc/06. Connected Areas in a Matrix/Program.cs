using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Connected_Areas_in_a_Matrix
{
    class Program
    {
        static bool[,] visited;
        static char[,] array;
        static Dictionary<string, int> areas;

        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            array = new char[row, col];
            visited = new bool[row, col];
            areas = new Dictionary<string, int>();

            FillField(array);
            Traverse();

            Console.WriteLine($"Total areas found: {areas.Count()}");

            int count = 1;           
            foreach (var area in areas.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"Area #{count} at ({area.Key}), size: {area.Value}");
                count++;
            }
        }

        private static void Traverse()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    if (visited[i, y] || array[i, y] == '*')
                        continue;
                    else
                    {
                        string key = $"{i}, {y}";
                        areas[key] = 0;
                        Solve(i, y, key);
                    }
                }
            }
        }

        private static void Solve(int row, int col, string key)
        {
            if (row < 0 || row >= array.GetLength(0) || col < 0 || col >= array.GetLength(1))
                return;

            if (array[row, col] == '*')
                return;

            if (visited[row, col] == true)
                return;

            visited[row, col] = true;
            areas[key]++;

            Solve(row + 1, col, key); // down
            Solve(row - 1, col, key); // up
            Solve(row, col + 1, key); // right
            Solve(row, col - 1, key); // left

        }

        private static void FillField(char[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                string line = Console.ReadLine();
                char[] inputLine = line.ToCharArray();

                for (int y = 0; y < array.GetLength(1); y++)
                {
                    array[i, y] = inputLine[y];
                }
            }
        }
    }
}
