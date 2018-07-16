using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int dancersAmount = int.Parse(Console.ReadLine());
            double pointsAmount = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string location = Console.ReadLine();

            double priceTotal = 0.0;
            switch (location)
            {
                case "Bulgaria":
                   priceTotal = dancersAmount * pointsAmount;
                    switch (season)
                    {
                        case "summer":
                            priceTotal -= priceTotal * 0.05;
                            break;
                        case "winter":
                            priceTotal -= priceTotal * 0.08;
                            break;

                    }
                    break;
                case "Abroad":
                    priceTotal = dancersAmount * pointsAmount + (dancersAmount * pointsAmount * 0.5);
                    switch (season)
                    {
                        case "summer":
                            priceTotal -= priceTotal * 0.1;
                            break;
                        case "winter":
                            priceTotal -= priceTotal * 0.15;
                            break;
                    }
                    break;
            }
            double charity = priceTotal * 0.75;
            priceTotal -= priceTotal * 0.75;
            double moneyPerDancer = priceTotal / dancersAmount;

            Console.WriteLine($"Charity - {charity:f2}");
            Console.WriteLine($"Money per dancer - {moneyPerDancer:F2}");
        }
    }
}
                                        