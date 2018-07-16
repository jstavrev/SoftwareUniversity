using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().ToLower().Split(' ').ToList();
            Dictionary<string, int> occurrencesCount = new Dictionary<string, int>();

            foreach (var element in input)
            {
                if (occurrencesCount.ContainsKey(element))
                {
                    occurrencesCount[element]++;
                }
                else
                {
                    occurrencesCount.Add(element, 1);
                }
            }
            List<string> output = new List<string>();
            foreach (var item in occurrencesCount)
            {
                if (item.Value % 2 != 0)
                {
                    output.Add(item.Key);
                }
            }
            Console.WriteLine(String.Join(", ", output));

        }
    }
}
