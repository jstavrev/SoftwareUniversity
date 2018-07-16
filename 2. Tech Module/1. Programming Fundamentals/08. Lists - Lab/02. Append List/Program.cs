using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|').ToArray();
            List<string> result = new List<string>();
            Array.Reverse(input);
            for (int i = 0; i < input.Length; i++)
            {
                string[] token = input[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in token)
                {
                    if (item != " ")
                    {
                        result.Add(item);

                    }
                }
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}