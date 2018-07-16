using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Byte_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            List<string> reversed = new List<string>();
            for (int i = 0; i < input.Count; i++)
            {
                string check = input[i];
                if (check.Length != 2)
                {
                    input.RemoveAt(i);
                    i--;
                    continue;
                }
                char[] arr = check.ToArray();
                Array.Reverse(arr);
                check = "";
                for (int j = 0; j < arr.Length; j++)
                {
                    check += arr[j];
                }
                reversed.Add(check);
            }
            reversed.Reverse();
            for (int i = 0; i < reversed.Count; i++)
            {
                Console.Write((char)Int16.Parse(reversed[i], NumberStyles.AllowHexSpecifier));
            }
            Console.WriteLine();
        }
    }
}
