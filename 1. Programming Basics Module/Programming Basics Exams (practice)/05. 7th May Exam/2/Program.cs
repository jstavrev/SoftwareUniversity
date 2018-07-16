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
            double vacationPrice = double.Parse(Console.ReadLine());
            int puzzleAmount = int.Parse(Console.ReadLine());
            int dollsAmount = int.Parse(Console.ReadLine());
            int bearsAmount = int.Parse(Console.ReadLine());
            int minionsAmount = int.Parse(Console.ReadLine());
            int trucksAmount = int.Parse(Console.ReadLine());


            double income = (puzzleAmount * 2.6) + (dollsAmount * 3) + (bearsAmount * 4.1) + (minionsAmount * 8.2) + (trucksAmount * 2);
            int orderAmount = puzzleAmount + dollsAmount + bearsAmount + minionsAmount + trucksAmount;
            if (orderAmount >= 50)
            {
                income = income - (income * 0.25);
            }
            double incomeTotal = income - (income * 0.1);
            double moneyDiff = Math.Abs(vacationPrice - incomeTotal);

            if (vacationPrice > incomeTotal)
            {
                Console.WriteLine($"Not enough money! {moneyDiff:F2} lv needed.");
            }
            else
            {
                Console.WriteLine($"Yes! {moneyDiff:f2} lv left.");
            }


        }
    }
}
