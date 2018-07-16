using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Words_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char lastLetter = 'z';
            char nextToLast = 'a';

            for (int i = 1; i < input.Length; i++)
            {
                lastLetter = input[i];
                nextToLast = input[i - 1];
            };
            if (lastLetter == 'y')
            {
                for (int i = 0; i < input.Length - 1; i++)
                {
                    Console.Write(input[i]);
                }
                Console.Write("ies");
                Console.WriteLine();
            }
            else if (lastLetter == 'o' || lastLetter == 's' || lastLetter == 'x' || lastLetter == 'z' || (nextToLast == 'c' && lastLetter == 'h') || (nextToLast == 's' && lastLetter == 'h'))
            {
                for (int i = 0; i < input.Length; i++)
                {
                    Console.Write(input[i]);
                }
                Console.Write("es");
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    Console.Write(input[i]);
                }
                Console.Write("s");
                Console.WriteLine();
            }

        }
    }
}