using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double currentBalance = balance;
            double balanceSpent = 0.0;
            double gamePrice = 0.0;

            while (true)
            {               
                string input = Console.ReadLine();

                if (input == "Game Time")
                {                       
                  break;                  
                }
                else if (input != "OutFall 4" && input != "CS: OG" && input != "Zplinter Zell" && input != "Honored 2" && input != "RoverWatch" && input != "RoverWatch Origins Edition")
                {
                    Console.WriteLine("Not Found");
                    continue;
                }
                else
                {
                    switch (input)
                    {
                        case "OutFall 4": gamePrice = 39.99; break;
                        case "CS: OG": gamePrice = 15.99; break;
                        case "Zplinter Zell": gamePrice = 19.99; break;
                        case "Honored 2": gamePrice = 59.99; break;
                        case "RoverWatch": gamePrice = 29.99; break;
                        case "RoverWatch Origins Edition": gamePrice = 39.99; break;
                    }                    
                    if (currentBalance >= gamePrice)
                    {
                        Console.WriteLine($"Bought {input}");
                        balanceSpent += gamePrice;
                        currentBalance -= gamePrice;
                    }
                    else if (currentBalance < gamePrice)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    if (balance - balanceSpent <= 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                }
            }
            if (balance - balanceSpent > 0)
            {
                Console.WriteLine($"Total spent: ${balanceSpent:F2}. Remaining: ${balance - balanceSpent:F2}");
            }
        }
    }
}
