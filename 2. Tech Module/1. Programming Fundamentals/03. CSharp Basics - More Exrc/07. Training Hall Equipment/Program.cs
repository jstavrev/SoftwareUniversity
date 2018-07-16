using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int itemsAmount = int.Parse(Console.ReadLine());
            double bill = 0.0;

            for (int i = 0; i < itemsAmount; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());
                if (itemCount == 1)
                {
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
                }
                bill += itemPrice * itemCount;
            }

            Console.WriteLine($"Subtotal: ${bill:F2}");
            if (budget - bill >= 0)
            {
                Console.WriteLine($"Money left: ${budget - bill:F2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${Math.Abs(budget - bill):F2} more.");
            }
            
        }
    }
}
