using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Eng_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            string name = GetTxtValue(num);
            Console.WriteLine(name);
        }

        static string GetTxtValue(string num)
        {
            int m = 0;
            for (int i = 0; i < num.Length; i++)
            {
                char val = num[i];
                m = (int)Char.GetNumericValue(val);
            }
            string value = "";
            switch (m)
            {
                case 1: value = "one"; break;
                case 2: value = "two"; break;
                case 3: value = "three"; break;
                case 4: value = "four"; break;
                case 5: value = "five"; break;
                case 6: value = "six"; break;
                case 7: value = "seven"; break;
                case 8: value = "eight"; break;
                case 9: value = "nine"; break;
                case 0: value = "zero"; break;
            }
            return value;
        }
    }
}
