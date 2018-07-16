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
            int cupsDemand = int.Parse(Console.ReadLine());
            int employesCount = int.Parse(Console.ReadLine());
            int workDaysAmount = int.Parse(Console.ReadLine());

            double totalWorkHours = employesCount * workDaysAmount * 8;
            double cupsManufactured = Math.Floor(totalWorkHours / 5);
            

            if (cupsManufactured >= cupsDemand)
            {
                double cupsPrice = (cupsManufactured - cupsDemand) * 4.2;
                Console.WriteLine($"{cupsPrice:F2} extra money");
            }
            else
            {
                double cupsPrice = (cupsDemand - cupsManufactured) * 4.2;
                Console.WriteLine($"Losses: { cupsPrice:F2}");
            }
        }
    }
}
