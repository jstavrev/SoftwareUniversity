using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int chefs = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int goffretes = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double dailyCakes = cakes * 45;
            double dailyGoffretes = goffretes * 5.80;
            double dailyPancakes = pancakes * 3.20;
            double dailyTotal = (dailyCakes + dailyGoffretes + dailyPancakes) * chefs;

            double total = dailyTotal * days;

            double totalAfterExpenses = total - (total * 1 / 8);

            Console.WriteLine("{0:F2}", totalAfterExpenses);
        }
    }
}
