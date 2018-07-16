using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            double totalCleaning = 1 / (1 / a + 1 / b + 1 / c);
            totalCleaning += totalCleaning * 0.15;
            double timeleft = Math.Ceiling(Math.Abs((totalCleaning - d)));

            if (d - totalCleaning > 0)
            {
                timeleft--;
                Console.WriteLine($"Cleaning time: {totalCleaning:F2}");
                Console.WriteLine($"Yes, there is a surprise - time left -> {timeleft} hours.");
            }
            else
            {
                Console.WriteLine($"Cleaning time: {totalCleaning:F2}");
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {timeleft} hours.");
            }
        }
    }
}
