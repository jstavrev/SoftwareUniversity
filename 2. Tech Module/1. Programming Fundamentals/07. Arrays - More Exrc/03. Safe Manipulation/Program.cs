using System;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ').ToArray();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "END")
                {
                    break;
                }

                if (input[0] != "Reverse" && input[0] != "Distinct" && input[0] != "Replace")
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
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
                        if (index < 0 || index > text.Length - 1)
                        {
                            Console.WriteLine("Invalid input!");
                            continue;
                        }
                        text[index] = input[2];
                    }
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