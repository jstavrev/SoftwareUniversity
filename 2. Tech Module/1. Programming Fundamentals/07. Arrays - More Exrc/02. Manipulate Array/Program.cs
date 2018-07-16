using System;
using System.Linq;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ').ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "Reverse")
                {
                    Array.Reverse(text);
                }
                else if (input[0] == "Distinct")
                {
                    text = text.Distinct().ToArray();
                }
                else if (input[0] == "Replace")
                {
                    int index = int.Parse(input[1]);
                    text[index] = input[2];
                }
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (i == text.Length - 1)
                {
                    Console.Write(text[i]);
                    break;
                }
                Console.Write(text[i] + ", ");
            }
            Console.WriteLine();

        }
    }
}
