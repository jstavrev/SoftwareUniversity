using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Longest_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int bestSequence = int.MinValue;
            int currentSequence = 1;
            int sequenceValue = 0;

            if (input.Count == 1)
            {
                Console.WriteLine(input[0]);
                Environment.Exit(0);
            }

            for (int i = 0; i < input.Count - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    currentSequence++;
                }
                else
                {
                    currentSequence = 1;
                }

                if (currentSequence > bestSequence)
                {
                    bestSequence = currentSequence;
                    sequenceValue = input[i];
                }
            }

            for (int i = 0; i < bestSequence - 1; i++)
            {
                Console.Write(sequenceValue + " ");
            }
            Console.WriteLine(sequenceValue);
        }
    }
}
