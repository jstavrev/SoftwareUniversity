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
            double budget = double.Parse(Console.ReadLine());
            double houseM = double.Parse(Console.ReadLine());
            int windowsAmount = int.Parse(Console.ReadLine());
            double stiroporPack = double.Parse(Console.ReadLine());
            double stiroporPrice = double.Parse(Console.ReadLine());

            double windowsM = windowsAmount * 2.4;
            double realhouseM = houseM - windowsM + ((houseM - windowsM) * 0.1);
            double stiroporNeeded = Math.Ceiling(realhouseM / stiroporPack);
            double totalPrice = stiroporNeeded * stiroporPrice;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Spent: {totalPrice:F2}");
                Console.WriteLine($"Left: {budget-totalPrice:F2}");
            }
            else
            {
                Console.WriteLine($"Need more: {Math.Abs(totalPrice-budget):F2}");
            }
        }
    }
}
