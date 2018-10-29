using System;
using System.Collections.Generic;

namespace _06._Queens_Puzzle
{
    class Program
    {
        static HashSet<int> beatenRow = new HashSet<int>();
        static HashSet<int> beatenCol = new HashSet<int>();
        static HashSet<int> beatenLeftDiagonals = new HashSet<int>();
        static HashSet<int> beatenRightDiagonals = new HashSet<int>();

        static void Main(string[] args)
        {
            int size = 8;

            int[,] chessboard = new int[size, size];
            int row = 0;
            int queens = 0;

            Solve(chessboard, row, queens);
        }

        private static void Solve(int[,] chessboard, int row, int queens)
        {
            if (row == 8)
            {
                Print(chessboard);
                return;
            }

            for (int col = 0; col < chessboard.GetLength(0); col++)
            {
                if (CanPlaceQueen(chessboard, row, col))
                {
                    chessboard[row, col] = 1;
                    queens++;
                    MarkBeaten(chessboard, row, col);

                    Solve(chessboard, row + 1, queens);

                    UnmarkBeaten(chessboard, row, col);
                    queens--;
                }
            }
        }

        private static void Print(int[,] chessboard)
        {
            for (int i = 0; i < chessboard.GetLength(0); i++)
            {
                for (int j = 0; j < chessboard.GetLength(1); j++)
                {
                    if (chessboard[i, j] == 1)
                        Console.Write("* ");
                    else
                        Console.Write("- ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void UnmarkBeaten(int[,] chessboard, int row, int col)
        {
            chessboard[row, col] = 0;

            beatenRow.Remove(row);

            beatenCol.Remove(col);

            beatenLeftDiagonals.Remove(col - row);

            beatenRightDiagonals.Remove(col + row);
        }

        private static void MarkBeaten(int[,] chessboard, int row, int col)
        {
            beatenRow.Add(row);

            beatenCol.Add(col);

            beatenLeftDiagonals.Add(col - row);

            beatenRightDiagonals.Add(col + row);
        }

        private static bool CanPlaceQueen(int[,] chessboard, int row, int col)
        {
            if (beatenRow.Contains(row) || beatenCol.Contains(col) || beatenLeftDiagonals.Contains(col - row) || beatenRightDiagonals.Contains(col + row))
            {
                return false;
            }

            if (chessboard[row, col] != 0)
            {
                return false;
            }

            return true;
        }
    }
}
