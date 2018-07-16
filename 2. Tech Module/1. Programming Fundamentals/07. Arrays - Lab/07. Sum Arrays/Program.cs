using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arrTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string[] stringArrOne = arrOne.Select(x => x.ToString()).ToArray();
            string[] stringArrTwo = arrTwo.Select(x => x.ToString()).ToArray();
            int arrMaxLength = Math.Max(stringArrOne.Length, stringArrTwo.Length);
            if (arrMaxLength == stringArrTwo.Length)
            {
                int[] arrBig = arrTwo;
                arrTwo = arrOne;
                arrOne = arrBig;

                string[] strBig = stringArrTwo;
                stringArrTwo = stringArrOne;
                stringArrOne = strBig;
            }
            int arrMinLength = Math.Min(stringArrOne.Length, stringArrTwo.Length);

            int[] arrResult = new int[arrMaxLength];
            for (int i = 0; i < arrMaxLength; i++)
            {
                arrResult[i] = arrOne[i % stringArrOne.Length] + arrTwo[i % stringArrTwo.Length];
            }
            for (int i = 0; i < arrMaxLength; i++)
            {
                Console.Write($"{arrResult[i]} ");
            }
            Console.WriteLine();
        }
    }
}
