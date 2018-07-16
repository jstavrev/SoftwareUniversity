using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string location = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            double price = 0.0;

            if (product == "coffee")
            {
                if (location == "Sofia")
                {
                    price = amount * 0.5;
                }
                if (location == "Plovdiv")
                {
                    price = amount * 0.4;
                }
                if (location == "Varna")
                {
                    price = amount * 0.45;
                }
            }

            if (product == "water")
            {
                if (location == "Sofia")
                {
                    price = amount * 0.8;
                }
                if (location == "Plovdiv")
                {
                    price = amount * 0.7;
                }
                if (location == "Varna")
                {
                    price = amount * 0.7;
                }

            }

            if (product == "beer")
            {
                if (location == "Sofia")
                {
                    price = amount * 1.2;
                }
                if (location == "Plovdiv")
                {
                    price = amount * 1.15;
                }
                if (location == "Varna")
                {
                    price = amount * 1.1;
                }
            }

            if (product == "sweets")
            {
                if (location == "Sofia")
                {
                    price = amount * 1.45;
                }
                if (location == "Plovdiv")
                {
                    price = amount * 1.3;
                }
                if (location == "Varna")
                {
                    price = amount * 1.35;
                }
            }

            if (product == "peanuts")
            {
                if (location == "Sofia")
                {
                    price = amount * 1.6;
                }
                if (location == "Plovdiv")
                {
                    price = amount * 1.5;
                }
                if (location == "Varna")
                {
                    price = amount * 1.55;
                }
            }

            Console.WriteLine(price);

        }
    }
}
