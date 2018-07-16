using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Ivanovi_s_Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            int nightsAmount = int.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string transportType = Console.ReadLine();
            double costsPerNight = 0.0;
            double transportCost = 0.0;

            if (nightsAmount >= 1 && nightsAmount <= 10)
            {
                switch (destination)
                {
                    case "Miami":
                        costsPerNight = 2 * 24.99 + 3 * 14.99;
                        break;
                    case "Canary Islands":
                        costsPerNight = 2 * 32.50 + 3 * 28.50;
                        break;
                    case "Philippines":
                        costsPerNight = 2 * 42.99 + 3 * 39.99;
                        break;
                }
            }
            else if (nightsAmount > 10 && nightsAmount <= 15)
            {
                switch (destination)
                {
                    case "Miami":
                        costsPerNight = 2 * 22.99 + 3 * 11.99;
                        break;
                    case "Canary Islands":
                        costsPerNight = 2 * 30.50 + 3 * 25.60;
                        break;
                    case "Philippines":
                        costsPerNight = 2 * 41 + 3 * 36;
                        break;
                }
            }
            else if (nightsAmount > 15)
            {
                switch (destination)
                {
                    case "Miami":
                        costsPerNight = 2 * 20 + 3 * 10;
                        break;
                    case "Canary Islands":
                        costsPerNight = 2 * 28 + 3 * 22;
                        break;
                    case "Philippines":
                        costsPerNight = 2 * 38.5 + 3 * 32.4;
                        break;
                }
            }
            switch (transportType)
            {
                case "train":
                    transportCost = 2 * 22.30 + 3 * 12.50;
                    break;
                case "bus":
                    transportCost = 2 * 45 + 3 * 37;
                    break;
                case "airplane":
                    transportCost = 2 * 90 + 3 * 68.5;
                    break;

            }

            double costsTotal = nightsAmount * costsPerNight + (nightsAmount * costsPerNight * 0.25) + transportCost;
            Console.WriteLine($"{costsTotal:F3}");
        }
    }
}
