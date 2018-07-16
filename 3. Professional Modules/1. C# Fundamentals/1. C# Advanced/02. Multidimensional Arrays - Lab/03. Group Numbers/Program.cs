using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Group_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> input = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[][] jagged = new int[3][];
            List<int> remainderZero = new List<int>();
            List<int> remainderOne = new List<int>();
            List<int> remainderTwo = new List<int>();


            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] % 3 == 0)
                {
                    remainderZero.Add(input[i]);                
                }
                else if(input[i] % 3 == 1 || input[i] % 3 == -1)
                {
                    remainderOne.Add(input[i]);
                }
                else if (input[i] % 3 == 2 || input[i] % 3 == -2)
                {
                    remainderTwo.Add(input[i]);
                }
            }

            jagged[0] = remainderZero.ToArray();
            jagged[1] = remainderOne.ToArray();
            jagged[2] = remainderTwo.ToArray();

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    if (j == jagged[i].Length - 1)
                    {
                        Console.Write(jagged[i][j]);
                        break;
                    }
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
