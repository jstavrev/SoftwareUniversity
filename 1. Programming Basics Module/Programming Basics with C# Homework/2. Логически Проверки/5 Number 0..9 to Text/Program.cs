using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Number_0._._9_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            if (input == 9)
            {
                Console.WriteLine("nine");
            }

            if (input == 8)
            {
                Console.WriteLine("eight");
            }

            if (input == 7)
            {
                Console.WriteLine("seven");
            }

            if (input == 6)
            {
                Console.WriteLine("six");
            }

            if (input == 5)
            {
                Console.WriteLine("five");
            }

            if (input == 4)
            {
                Console.WriteLine("four");
            }

            if (input == 3)
            {
                Console.WriteLine("three");
            }

            if (input == 2)
            {
                Console.WriteLine("two");
            }

            if (input == 1)
            {
                Console.WriteLine("one");
            }

            if (input == 0)
            {
                Console.WriteLine("zero");
            }

            if (input > 9)
            {
                Console.WriteLine("number too big");
            }
        }
    }
}
