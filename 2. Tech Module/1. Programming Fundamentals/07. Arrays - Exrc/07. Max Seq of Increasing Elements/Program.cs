using System;
using System.Linq;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int start = 0; //Zadavam variable, koito shte zapazva nachaloto na vseki sequence.
            int length = 1; //Zadavam variable, koito shte zapazva duljinata na vseki sequence.
            int bestStart = 0; //Zadavam variable, koito she zapazva nachaloto na nai golemiq sequence za momenta.
            int bestLen = 1; //Zadavam variable, koito she zapazva duljinata na nai golemiq sequence za momenta.

            for (int i = 0; i < n.Length; i++)
            {
                if (i == n.Length - 1)
                {
                    break;
                }
                if (n[i] < n[i + 1])
                {
                    length++;
                }
                else
                {
                    start = i + 1;
                    length = 1;
                }
                if (length > bestLen)
                {
                    bestLen = length;
                    bestStart = start;
                }
            }
            for (int i = bestStart; i < bestStart + bestLen; i++)
            {
                Console.Write(n[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
