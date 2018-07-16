using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();

            char letterOne = a[0];
            char letterTwo = b[0];
            char letterThree = c[0];

            for (char i = letterOne; i <= letterTwo; i++)
            {
                for (char y = letterOne; y <= letterTwo; y++)
                {
                    for (char k = letterOne; k <= letterTwo; k++)
                    {
                        if (i != letterThree && y != letterThree && k != letterThree)
                        {
                            Console.Write($"{i}{y}{k} ");
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}