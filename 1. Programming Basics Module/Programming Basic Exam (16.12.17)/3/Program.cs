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
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string review = Console.ReadLine();

            double pricePerNight = 0.0;
            switch (roomType)
            {
                case "room for one person":
                    pricePerNight = 18;
                    break;
                case "apartment":
                    pricePerNight = 25;
                    break;
                case "president apartment":
                    pricePerNight = 35;
                    break;
            }
            double totalPrice = (days - 1) * pricePerNight;

            switch (roomType)
            {
                case "apartment":
                    if (days < 10)
                    {
                        totalPrice -= totalPrice * 0.3;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        totalPrice -= totalPrice * 0.35;
                    }
                    else if (days > 15)
                    {
                        totalPrice -= totalPrice * 0.5;
                    }
                    break;
                case "president apartment":
                    if (days < 10)
                    {
                        totalPrice -= totalPrice * 0.1;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        totalPrice -= totalPrice * 0.15;
                    }
                    else if (days > 15)
                    {
                        totalPrice -= totalPrice * 0.2;
                    }
                    break;
            }
            switch (review)
            {
                case "positive":
                    totalPrice += totalPrice * 0.25;
                    break;
                case "negative":
                    totalPrice -= totalPrice * 0.1;
                    break;
            }
            Console.WriteLine($"{totalPrice:F2}");




        }
    }
}
