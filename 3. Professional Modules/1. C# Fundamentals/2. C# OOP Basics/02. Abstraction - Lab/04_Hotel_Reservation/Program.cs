using System;
using System.Linq;

namespace _04_Hotel_Reservation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            double pricePerDay = double.Parse(input[0]);
            int numberOfDays = int.Parse(input[1]);
            Seasons season = Enum.Parse<Seasons>(input[2]);
            DiscountType discount = DiscountType.None;
            if (input.Length == 4)
            {
                discount = Enum.Parse<DiscountType>(input[3]);
            }

            Console.WriteLine($"{PriceCalculator.CalculatePrice(pricePerDay, numberOfDays, season, discount):F2}");
        }
    }
}
