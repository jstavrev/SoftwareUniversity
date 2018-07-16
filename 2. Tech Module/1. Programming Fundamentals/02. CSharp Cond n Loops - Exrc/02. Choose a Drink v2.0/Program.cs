using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());

            switch (profession)
            {
                case "Athlete": Console.WriteLine("The Athlete has to pay {0:0.00}.", 0.70 * amount); break;
                case "Businessman": Console.WriteLine("The Businessman has to pay {0:0.00}.", 1.00 * amount); break;
                case "Businesswoman": Console.WriteLine("The Businesswoman has to pay {0:0.00}.", 1.00 * amount); break;
                case "SoftUni Student": Console.WriteLine("The SoftUni Student has to pay {0:0.00}.", 1.70 * amount); break;
                default: Console.WriteLine("The {0} has to pay {1:0.00}.", profession, 1.20 * amount); break;
            }
        }
    }
}