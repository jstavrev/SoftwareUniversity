using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dwarf_present
{
    class Program
    {
        static void Main(string[] args)
        {
            int dwarfsAmount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double moneySpent = 0;
            for (int i = 0; i < dwarfsAmount; i++)
            {
                string present = Console.ReadLine();
                switch (present)
                {
                    case "sand clock": moneySpent += 2.2 ;
                        break;
                    case "magnet":
                        moneySpent += 1.5 ;
                        break;
                    case "cup":
                        moneySpent += 5 ;
                        break;
                    case "t-shirt":
                        moneySpent += 10 ;
                        break;
                }
            }
            if (budget >= moneySpent)
            {
                double balance = budget - moneySpent;
                Console.WriteLine($"Santa Claus has {balance:F2} more leva left!");
            }
            else
            {
                double balance = budget - moneySpent;
                balance = Math.Abs(balance);
                Console.WriteLine($"Santa Claus will need {balance:F2} more leva.");
            }
        }
    }
}
