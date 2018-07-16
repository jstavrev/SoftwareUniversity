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
            char bigLetter = char.Parse(Console.ReadLine());
            char smallLetterOne = char.Parse(Console.ReadLine());
            char smallLetterTwo = char.Parse(Console.ReadLine());
            char smallLetterThree = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int i = 'A'; i <= bigLetter; i++)
            {
                for (int y = 'a'; y <= smallLetterOne; y++)
                {
                    for (int j = 'a'; j <= smallLetterTwo; j++)
                    {
                        for (int k = 'a'; k <= smallLetterThree; k++)
                        {
                            for (int l = 0; l <= n; l++)
                            {
                                counter++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter-1);

        }
    }
}
