using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrWordsOne = Console.ReadLine().Split(' ').ToArray();
            string[] arrWordsTwo = Console.ReadLine().Split(' ').ToArray();

            FindLargestCommonEnd(arrWordsOne, arrWordsTwo);
        }

        private static void FindLargestCommonEnd(string[] arrWordsOne, string[] arrWordsTwo)
        {
            int countRight = 0;
            int countLeft = 0;
            int minLength = Math.Min(arrWordsOne.Length, arrWordsTwo.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (arrWordsOne[i] == arrWordsTwo[i])
                {
                    countLeft++;
                }
                else break;
            }

            Array.Reverse(arrWordsOne); Array.Reverse(arrWordsTwo);

            for (int i = 0; i < minLength; i++)
            {
                if (arrWordsOne[i] == arrWordsTwo[i])
                {
                    countRight++;
                }
                else break;
            }

            int result = Math.Max(countLeft, countRight);
            Console.WriteLine(result);
        }
    }
}
