using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sequenceCounter = 0;
            int sum = 0;

            for (char i = 'A'; i <= 'T'; i++)
            {
                for (char y = 'A'; y <= 'T'; y++)
                {
                    for (char j = 'A'; j <= 'T'; j++)
                    {
                        if ((i == 'A' || i == 'C' || i == 'G' || i == 'T') && ((y == 'A' || y == 'C' || y == 'G' || y == 'T')) && ((j == 'A' || j == 'C' || j == 'G' || j == 'T')))
                        {
                            switch (i)
                            {
                                case 'A': sum += 1; break;
                                case 'C': sum += 2; break;
                                case 'G': sum += 3; break;
                                case 'T': sum += 4; break;
                            }
                            switch (y)
                            {
                                case 'A': sum += 1; break;
                                case 'C': sum += 2; break;
                                case 'G': sum += 3; break;
                                case 'T': sum += 4; break;
                            }
                            switch (j)
                            {
                                case 'A': sum += 1; break;
                                case 'C': sum += 2; break;
                                case 'G': sum += 3; break;
                                case 'T': sum += 4; break;
                            }
                            if (sum >= n)
                            {
                                Console.Write($"O{i}{y}{j}O ");
                                sum = 0;
                            }
                            else
                            {
                                Console.Write($"X{i}{y}{j}X ");
                                sum = 0;
                            }                           
                            sequenceCounter++;
                        }
                        if (sequenceCounter == 4)
                        {
                            Console.WriteLine();
                            sequenceCounter = 0;
                        }
                    }
                }
            }
        }
    }
}
