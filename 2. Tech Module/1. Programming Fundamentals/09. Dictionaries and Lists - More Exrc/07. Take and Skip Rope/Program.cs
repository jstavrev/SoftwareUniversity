using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Take_and_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] arr = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            List<int> numbers = new List<int>();
            List<char> letters = new List<char>();
            string result = "";
            int currentIndex = 0; ;
            for (int i = 0; i < input.Length; i++)
            {
                if (arr.Contains(input[i]))
                    numbers.Add((int)char.GetNumericValue(input[i]));
                else
                    letters.Add(input[i]);
            }
            List<int> take = new List<int>();
            List<int> skip = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                    take.Add(numbers[i]);
                else
                    skip.Add(numbers[i]);
            }
            for (int i = 0; i < take.Count; i++)
            {
                for (int j = currentIndex; j < currentIndex + take[i]; j++)
                {
                    if (j >= letters.Count)
                        break;
                    result += letters[j];
                }
                currentIndex += skip[i] + take[i];
            }
            Console.WriteLine(result);
        }
    }
}
