using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double amount = double.Parse(Console.ReadLine());

            double price = 0.0;

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (product == "banana")
                {
                    price = amount * 2.5;
                    Console.WriteLine("{0:0.00}", Math.Round(price, 2));
                }
                else if (product == "apple")
                {
                    price = amount * 1.2;
                    Console.WriteLine("{0:0.00}", Math.Round(price, 2));
                }
                else if (product == "orange")
                {
                    price = amount * 0.85;
                    Console.WriteLine("{0:0.00}", Math.Round(price, 2));
                }
                else if (product == "grapefruit")
                {
                    price = amount * 1.45;
                    Console.WriteLine("{0:0.00}", Math.Round(price, 2));
                }
                else if (product == "kiwi")
                {
                    price = amount * 2.7;
                    Console.WriteLine("{0:0.00}", Math.Round(price, 2));
                }
                else if (product == "pineapple")
                {
                    price = amount * 5.5;
                    Console.WriteLine("{0:0.00}", Math.Round(price, 2));
                }
                else if (product == "grapes")
                {
                    price = amount * 3.85;
                    Console.WriteLine("{0:0.00}", Math.Round(price, 2));
                }
                else
                {
                    Console.WriteLine("error");
                }

            }

            else if (day == "saturday" || day == "sunday")
            {
                if (product == "banana")
                {
                    price = amount * 2.7;
                    Console.WriteLine("{0:0.00}", Math.Round(price, 2));
                }
                else if (product == "apple")
                {
                    price = amount * 1.25;
                    Console.WriteLine("{0:0.00}", Math.Round(price, 2));
                }
                else if (product == "orange")
                {
                    price = amount * 0.9;
                    Console.WriteLine("{0:0.00}", Math.Round(price, 2));
                }
                else if (product == "grapefruit")
                {
                    price = amount * 1.6;
                    Console.WriteLine("{0:0.00}", Math.Round(price, 2));
                }
                else if (product == "kiwi")
                {
                    price = amount * 3.0;
                    Console.WriteLine("{0:0.00}", Math.Round(price, 2));
                }
                else if (product == "pineapple")
                {
                    price = amount * 5.6;
                    Console.WriteLine("{0:0.00}", Math.Round(price, 2));
                }
                else if (product == "grapes")
                {
                    price = amount * 4.2;
                    Console.WriteLine("{0:0.00}", Math.Round(price, 2));
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
