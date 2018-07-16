using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int kcalAmount = 0;

            for (int i = 0; i < n; i++)
            {
                string ingredients = Console.ReadLine();
                ingredients = ingredients.ToLower();
                if (ingredients == "cheese" || ingredients == "tomato sauce" || ingredients == "salami" || ingredients == "pepper")
                {
                    switch (ingredients)
                    {
                        case "cheese": kcalAmount += 500; break;
                        case "tomato sauce": kcalAmount += 150; break;
                        case "salami": kcalAmount += 600; break;
                        case "pepper": kcalAmount += 50; break;
                    }
                }
            }
            Console.WriteLine($"Total calories: {kcalAmount}");
        }
    }
}