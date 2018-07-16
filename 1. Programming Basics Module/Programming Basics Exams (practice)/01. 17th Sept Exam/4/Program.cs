using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double amountTotal = 0;
            double temperatureTotal = 0;

            for (int i = 0; i < n; i++)
            {
                double amount = double.Parse(Console.ReadLine());
                double temperature = double.Parse(Console.ReadLine());

                amountTotal += amount;
                temperatureTotal += amount * temperature;
            }
            Console.WriteLine($"Liter: {amountTotal:F2}");
            Console.WriteLine($"Degrees: {(temperatureTotal / amountTotal):F2}");
            if (temperatureTotal / amountTotal < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (temperatureTotal / amountTotal >= 38 && temperatureTotal / amountTotal <= 42)
            {
                Console.WriteLine("Super!");
            }
            else if (temperatureTotal / amountTotal > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
