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
            double stepsAmount = double.Parse(Console.ReadLine());
            double dancersAmount = double.Parse(Console.ReadLine());
            double daysAmount = double.Parse(Console.ReadLine());

            double stepsDailyTotal = Math.Ceiling(((stepsAmount / daysAmount) / stepsAmount) * 100);
            double percentPerDancer = stepsDailyTotal / dancersAmount;
               
            if (stepsDailyTotal <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {percentPerDancer:F2}%.");
            }
            else
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {percentPerDancer:F2}% steps to be learned per day.");
            }
        }
    }
}
