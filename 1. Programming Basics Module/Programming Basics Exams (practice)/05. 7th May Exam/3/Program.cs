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
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int studentsAmount = int.Parse(Console.ReadLine());
            int nightsAmount = int.Parse(Console.ReadLine());

            double pricePerNight = 0.0;
            switch (season)
            {
                case "Winter":
                    if (groupType == "mixed")
                    {
                        pricePerNight = 10;
                    }
                    else
                    {
                        pricePerNight = 9.6;
                    }
                    break;
                case "Spring":
                    if (groupType == "mixed")
                    {
                        pricePerNight = 9.5;
                    }
                    else
                    {
                        pricePerNight = 7.2;
                    }
                    break;
                case "Summer":
                    if (groupType == "mixed")
                    {
                        pricePerNight = 20;
                    }
                    else
                    {
                        pricePerNight = 15;
                    }
                    break;
            }
            string sport = "";
            switch (groupType)
            {
                case "girls":
                    switch (season)
                    {
                        case "Winter": sport = "Gymnastics"; break;
                        case "Spring": sport = "Athletics"; break;
                        case "Summer": sport = "Volleyball"; break;
                    }
                    break;
                case "boys":
                    switch (season)
                    {
                        case "Winter": sport = "Judo"; break;
                        case "Spring": sport = "Tennis"; break;
                        case "Summer": sport = "Football"; break;
                    }
                    break;
                case "mixed":
                    switch (season)
                    {
                        case "Winter": sport = "Ski"; break;
                        case "Spring": sport = "Cycling"; break;
                        case "Summer": sport = "Swimming"; break;
                    }
                    break;
            }
            double totalPrice = studentsAmount * (pricePerNight * nightsAmount);

            if (studentsAmount >= 50)
            {
                totalPrice -= totalPrice * 0.5;
            }
            else if (studentsAmount >= 20 && studentsAmount < 50)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (studentsAmount >= 10 && studentsAmount < 20)
            {
                totalPrice -= totalPrice * 0.05;
            }

            Console.WriteLine($"{sport} {totalPrice:f2} lv.");


        }
    }
}
