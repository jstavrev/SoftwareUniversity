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
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int orderAmount = int.Parse(Console.ReadLine());

            double price = 0;

            if (size == "small")
            {
                switch (fruit)
                {
                    case "Watermelon": price = 56 * 2; break;
                    case "Mango": price = 36.66 * 2; break;
                    case "Pineapple": price = 42.10 * 2; break;
                    case "Raspberry": price = 20 * 2; break;
                }
            }
            else if (size == "big")
            {
                switch (fruit)
                {
                    case "Watermelon": price = 28.70 * 5; break;
                    case "Mango": price = 19.60 * 5; break;
                    case "Pineapple": price = 24.80 * 5; break;
                    case "Raspberry": price = 15.20 * 5; break;
                }
            }

            double totalPrice = price * orderAmount;

            if (totalPrice >= 400 && totalPrice <= 1000)
            {
                totalPrice -= (totalPrice * 0.15);
            }
            else if (totalPrice > 1000)
            {
                totalPrice -= (totalPrice * 0.50);
            }
            Console.WriteLine("{0:F2} lv.", totalPrice);
        }
    }
}
