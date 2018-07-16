using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var bonusScore = 0.0;


            if (number > 1000)
            {
               
                bonusScore = number * 0.10;
            }
            else if (number > 100)
            {
             
                bonusScore = number * 0.20;
            }
            else if (number <= 100)
            {
                bonusScore = 5;
            }

            if (number % 2 == 0)
            {
                bonusScore = bonusScore + 1;
            }
            else if (number % 10 == 5)
            {
                bonusScore = bonusScore + 2;
            }
            Console.WriteLine(bonusScore);
            Console.WriteLine(number + bonusScore);
            

        }
    }
}
