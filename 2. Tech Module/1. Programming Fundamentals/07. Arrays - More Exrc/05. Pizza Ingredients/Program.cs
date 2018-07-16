using System;
using System.Linq;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ').ToArray();
            string ingredients = "";
            int length = int.Parse(Console.ReadLine());
            string check = "";
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                check = text[i];
                if (check.Length == length)
                {
                    Console.WriteLine("Adding {0}.", check);
                    counter++;
                    ingredients += text[i] + " ";
                }
                if (counter > 9)
                {
                    break;
                }
            }
            string[] ingredientsString = ingredients.Split(' ').ToArray();

            Console.WriteLine("Made pizza with total of {0} ingredients.", counter);
            Console.Write("The ingredients are: ");
            for (int i = 0; i < ingredientsString.Length - 1; i++)
            {
                if (i == ingredientsString.Length - 2)
                {
                    Console.Write("{0}.", ingredientsString[i]);
                    break;
                }
                Console.Write("{0}, ", ingredientsString[i]);
            }
            Console.WriteLine();
        }
    }
}
