using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            int.TryParse(input, out int digit);
            bool checker = Convert.ToBoolean(digit);

            bool lowerCase = input == "a" || input == "e" || input == "i" || input == "o" || input == "u" || input == "y";
            bool upperCase = input == "A" || input == "E" || input == "I" || input == "O" || input == "U" || input == "Y";

            if (checker && (digit >= 0 && digit <= 9))
            {
                Console.WriteLine("digit");
            }
            else if (lowerCase || upperCase)
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
