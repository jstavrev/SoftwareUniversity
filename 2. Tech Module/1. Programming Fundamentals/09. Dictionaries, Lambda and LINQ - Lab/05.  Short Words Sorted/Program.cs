using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().ToLower().Split(new char[] { '.', ',', ';', ':', '(', ')', '[', ']', '"', '\'', '?', '!', '\\', '/', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var inputDistincted = input.Distinct().ToList();
            Console.WriteLine(String.Join(", ", inputDistincted
                .Where(p => p.Length < 5)
                .OrderBy(p => p)
                ));

        }
    }
}