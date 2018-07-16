using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string requestedPackage = Console.ReadLine();

            double price;

            if (groupSize <= 50)
            {
                price = 2500;
                switch (requestedPackage)
                {
                    case "Normal":
                        price = (2500 + 500) - ((2500 + 500) * 0.05);
                        Console.WriteLine("We can offer you the Small Hall");
                        Console.WriteLine("The price per person is {0:0.00}$", price / groupSize);
                        break;
                    case "Gold":
                        price = (2500 + 750) - ((2500 + 750) * 0.10);
                        Console.WriteLine("We can offer you the Small Hall");
                        Console.WriteLine("The price per person is {0:0.00}$", price / groupSize);
                        break;
                    case "Platinum":
                        price = (2500 + 1000) - ((2500 + 1000) * 0.15);
                        Console.WriteLine("We can offer you the Small Hall");
                        Console.WriteLine("The price per person is {0:0.00}$", price / groupSize);
                        break;
                }
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                price = 5000;
                switch (requestedPackage)
                {
                    case "Normal":
                        price = (5000 + 500) - ((5000 + 500) * 0.05);
                        Console.WriteLine("We can offer you the Terrace");
                        Console.WriteLine("The price per person is {0:0.00}$", price / groupSize);
                        break;
                    case "Gold":
                        price = (5000 + 750) - ((5000 + 750) * 0.10);
                        Console.WriteLine("We can offer you the Terrace");
                        Console.WriteLine("The price per person is {0:0.00}$", price / groupSize);
                        break;
                    case "Platinum":
                        price = (5000 + 1000) - ((5000 + 1000) * 0.15);
                        Console.WriteLine("We can offer you the Terrace");
                        Console.WriteLine("The price per person is {0:0.00}$", price / groupSize);
                        break;
                }
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                price = 7500;
                switch (requestedPackage)
                {
                    case "Normal":
                        price = (7500 + 500) - ((7500 + 500) * 0.05);
                        Console.WriteLine("We can offer you the Great Hall");
                        Console.WriteLine("The price per person is {0:0.00}$", price / groupSize);
                        break;
                    case "Gold":
                        price = (7500 + 750) - ((7500 + 750) * 0.10);
                        Console.WriteLine("We can offer you the Great Hall");
                        Console.WriteLine("The price per person is {0:0.00}$", price / groupSize);
                        break;
                    case "Platinum":
                        price = (7500 + 1000) - ((7500 + 1000) * 0.15);
                        Console.WriteLine("We can offer you the Great Hall");
                        Console.WriteLine("The price per person is {0:0.00}$", price / groupSize);
                        break;
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}