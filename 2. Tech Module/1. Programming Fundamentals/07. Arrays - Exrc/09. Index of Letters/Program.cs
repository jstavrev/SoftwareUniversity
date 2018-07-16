using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26];

            int start = 97;
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)start;
                start++;
            }
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (text[i] == alphabet[j])
                    {
                        Console.WriteLine("{0} -> {1}", text[i], j);
                    }
                }
            }
        }
    }
}
