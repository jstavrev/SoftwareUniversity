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
            int dancersAmount = int.Parse(Console.ReadLine());

            double energyExpended = 0.0;
            for (int i = 1; i <= n; i++)
            {
                int dailyHours = int.Parse(Console.ReadLine());

                if (i % 2 == 0 && dailyHours % 2 == 0)
                {
                    energyExpended += 68 * dancersAmount;
                }
                else if (i % 2 != 0 && dailyHours % 2 == 0)
                {
                    energyExpended += 49 * dancersAmount;
                }
                else if (i % 2 == 0 && dailyHours % 2 != 0)
                {
                    energyExpended += 65 * dancersAmount;
                }
                else if (i % 2 != 0 && dailyHours % 2 != 0)
                {
                    energyExpended += 30 * dancersAmount;
                }
            }
            double totalEnergy = 100 * n * dancersAmount;
            double energyLeft = totalEnergy - energyExpended;
            double energyPerDancer = energyLeft / n / dancersAmount;

            if (energyPerDancer < 50)
            {
                Console.WriteLine($"They are wasted! Energy left: {energyPerDancer:F2}");
            }
            else
            {
                Console.WriteLine($"They feel good! Energy left: {energyPerDancer:F2}");
            }
        }
    }
}
