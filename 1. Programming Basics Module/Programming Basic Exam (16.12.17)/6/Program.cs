using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int startNumFour = start % 10;
            start = start / 10;
            int startNumThree = start % 10;
            start = start / 10;
            int startNumTwo = start % 10;
            start = start / 10;
            int startNumOne = start % 10;

            int endNumFour = end % 10;
            end = end / 10;
            int endNumThree = end % 10;
            end = end / 10;
            int endNumTwo = end % 10;
            end = end / 10;
            int endNumOne = end % 10;

            for (int i = startNumOne; i <= endNumOne; i++)
            {
                for (int y = startNumTwo; y <= endNumTwo; y++)
                {
                    for (int j = startNumThree; j <= endNumThree; j++)
                    {
                        for (int k = startNumFour; k <= endNumFour; k++)
                        {
                            if (i % 2 != 0 && y % 2 != 0 && j % 2 != 0 && k % 2 != 0)
                            {
                                Console.Write($"{i}{y}{j}{k} ");
                            }
                        }
                    }
                }
            }

        }
    }
}
