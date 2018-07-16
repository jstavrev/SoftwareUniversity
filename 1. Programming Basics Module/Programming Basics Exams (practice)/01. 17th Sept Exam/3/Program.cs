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
            string contractLength = Console.ReadLine();
            string contractType = Console.ReadLine();
            string addonInet = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());

            double price = 0;

            if (contractLength == "one")
            {
                switch (contractType)
                {
                    case "Small": price = 9.98; break;
                    case "Middle": price = 18.99; break;
                    case "Large": price = 25.98; break;
                    case "ExtraLarge": price = 35.99; break;
                }
            }
            else
            {
                switch (contractType)
                {
                    case "Small": price = 8.58; break;
                    case "Middle": price = 17.09; break;
                    case "Large": price = 23.59; break;
                    case "ExtraLarge": price = 31.79; break;
                }
            }

            if (addonInet == "yes")
            {
                if (price <= 10)
                {
                    price += 5.50;
                }
                else if (price > 10 && price <= 30)
                {
                    price += 4.35;
                }
                else if (price > 30)
                {
                    price += 3.85;
                }               
            }
            price *= months;
            if (contractLength == "two")
            {
                price -= price * 0.0375;
            }
            Console.WriteLine("{0:F2} lv.", price);
        }
    }
}
