using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] { ',', ';', ':', '.', '!', '(',  ')',  '"', '\'',  '\\',  '/', '[',  ']', ' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> upperCase = new List<string>();
            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            int upperCheck = 0;
            int lowerCheck = 0;
            string checkInput = "";

            for (int i = 0; i < input.Count; i++)
            {
                checkInput = input[i];
                for (int y = 0; y < checkInput.Length; y++)
                {
                    if (checkInput[y] >= 65 && checkInput[y] <= 90)
                    {
                        upperCheck++;
                    }
                    else if (checkInput[y] >= 97 && checkInput[y] <= 122)
                    {
                        lowerCheck++;
                    }
                }
                if (upperCheck == checkInput.Length)
                {
                    upperCase.Add(checkInput);
                }
                else if (lowerCheck == checkInput.Length)
                {
                    lowerCase.Add(checkInput);
                }
                else
                {
                    mixedCase.Add(checkInput);
                }
                upperCheck = 0;
                lowerCheck = 0;
            }
            Console.WriteLine("Lower-case: " + String.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: " + String.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: " + String.Join(", ", upperCase));
        }
    }
}
