using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[] charArray = new char[n];
            for (int i = 0; i <= n - 1; i++)
            {
                charArray[i] = char.Parse(Console.ReadLine());           
            }
            string word = new string(charArray);
            Console.WriteLine("The word is: {0}", word);
        }
    }
}
