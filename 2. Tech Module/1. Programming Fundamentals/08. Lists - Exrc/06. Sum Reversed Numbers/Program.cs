using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split(' ').ToList();
            List<int> numsReversed = new List<int>(nums.Count);

            for (int i = 0; i < nums.Count; i++)
            {
                string text = nums[i];
                string text1 = "";
                char[] charsArr = text.ToCharArray();
                Array.Reverse(charsArr);
                for (int y = 0; y < charsArr.Length; y++)
                {
                    text1 += charsArr[y];
                }
                numsReversed.Add(int.Parse(text1));
                text1 = "";
            }
            Console.WriteLine(numsReversed.Sum());
        }
    }
}
