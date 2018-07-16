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
            double packageWeight = double.Parse(Console.ReadLine());
            string orderType = Console.ReadLine();
            int km = int.Parse(Console.ReadLine());

            double pricePerKm = 0.0;
            switch (orderType)
            {
                case "standard":
                if (packageWeight < 1)
                    {
                        pricePerKm = 0.03;
                    }
                else if (packageWeight >= 1 && packageWeight <= 10)
                    {
                        pricePerKm = 0.05;
                    }
                else if (packageWeight >= 11 && packageWeight <= 40)
                    {
                        pricePerKm = 0.1;
                    }
                else if (packageWeight >= 41 && packageWeight <= 90)
                    {
                        pricePerKm = 1.15;
                    }
                else
                    {
                        pricePerKm = 0.2;
                    }
                    break;
                case "express":
                    if (packageWeight < 1)
                    {
                        pricePerKm = 0.03;
                    }
                    else if (packageWeight >= 1 && packageWeight <= 10)
                    {
                        pricePerKm = 0.05;
                    }
                    else if (packageWeight >= 11 && packageWeight <= 40)
                    {
                        pricePerKm = 0.1;
                    }
                    else if (packageWeight >= 41 && packageWeight <= 90)
                    {
                        pricePerKm = 0.15;
                    }
                    else
                    {
                        pricePerKm = 0.2;
                    }
                    break;
            }
            double totalPrice = pricePerKm * km;
            if (orderType == "express")
            {
                double expressPrice = 0.0;
                if (packageWeight < 1)
                {
                    expressPrice = 0.03 * 0.8;
                }
                else if (packageWeight >= 1 && packageWeight <= 10)
                {
                    expressPrice = 0.05 * 0.4;
                }
                else if (packageWeight >= 11 && packageWeight <= 40)
                {
                    expressPrice = 0.1 * 0.05;
                }
                else if (packageWeight >= 41 && packageWeight <= 90)
                {
                    expressPrice = 0.15 * 0.02;
                }
                else
                {
                    expressPrice = 0.2 * 0.01;
                }
                double expressCost = packageWeight * expressPrice;
                double expressTotal = expressCost * km;
                totalPrice += expressTotal;

            }

            Console.WriteLine($"The delivery of your shipment with weight of {packageWeight:F3} kg. would cost {totalPrice:F2} lv.");

        }
    }
}
