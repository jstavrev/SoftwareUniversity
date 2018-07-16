using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 'a'; i < 'a' + n; i++)
            {
                for (int j = 'a'; j < 'a' + n; j++)
                {
                    for (int y = 'a'; y < 'a' + n; y++)
                    {
                        char one = (char)i;
                        char two = (char)j;
                        char three = (char)y;
                        Console.WriteLine($"{one}{two}{three}");
                    }
                }
            }
        }
    }
}
