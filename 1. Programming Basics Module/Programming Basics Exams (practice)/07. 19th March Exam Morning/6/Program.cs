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
            int magicNum = int.Parse(Console.ReadLine());

            int loopCounter = 0;
            bool checker = true;
            for (int i = start; i >= end; i--)
            {
                for (int y = start; y >= end; y--)
                {
                    loopCounter++;
                    if (y + i == magicNum)
                    {
                        Console.WriteLine($"Combination N:{loopCounter} ({i} + {y} = {magicNum})");
                        checker = false;
                        break;
                    }
                }
                if (checker == false)
                {
                    break;
                }
            }
            if (checker)
            {
                Console.WriteLine($"{loopCounter} combinations - neither equals {magicNum}");
            }

        }
    }
}
