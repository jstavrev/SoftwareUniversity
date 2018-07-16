using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sort_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            List<TimeSpan> times = new List<TimeSpan>();
            for (int i = 0; i < input.Count; i++)
            {
                times.Add(TimeSpan.Parse(input[i]));
            }
            times.Sort();
            input.Clear();
            foreach (var item in times)
            {
                string formattedTimespan = item.ToString("hh\\:mm");
                input.Add(formattedTimespan);
            }
            Console.WriteLine(String.Join(", ", input));
        }
    }
}
