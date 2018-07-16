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
            double daysAway = double.Parse(Console.ReadLine());
            double foodLeftKG = double.Parse(Console.ReadLine());
            double DeerOneFood = double.Parse(Console.ReadLine());
            double DeerTwoFood = double.Parse(Console.ReadLine());
            double DeerThreeFood = double.Parse(Console.ReadLine());

            double totalFoodReq = daysAway * DeerOneFood + daysAway * DeerTwoFood + daysAway * DeerThreeFood;

            if (foodLeftKG >= totalFoodReq)
            {
                double balance = Math.Floor(foodLeftKG - totalFoodReq);
                Console.WriteLine($"{balance} kilos of food left.");
            }
            else
            {
                double balance = Math.Ceiling(totalFoodReq - foodLeftKG);               
                Console.WriteLine($"{balance} more kilos of food are needed.");
            }
        }
    }
}
