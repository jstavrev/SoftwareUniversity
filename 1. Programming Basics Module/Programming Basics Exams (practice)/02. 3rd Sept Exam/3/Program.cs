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
            int picturesAmount = int.Parse(Console.ReadLine());
            string picturesType = Console.ReadLine();
            string orderType = Console.ReadLine();

            double pricePerPicture = 0.0;
            double totalPrice = 0.0;
            switch (picturesType)
            {
                case "9X13":
                    pricePerPicture = 0.16;
                    totalPrice = picturesAmount * pricePerPicture;
                    if (picturesAmount >= 50)
                    {
                        totalPrice -= totalPrice * 0.05;
                    }
                    break;
                case "10X15":
                    pricePerPicture = 0.16;
                    totalPrice = picturesAmount * pricePerPicture;
                    if (picturesAmount >= 80)
                    {
                        totalPrice -= totalPrice * 0.03;
                    }
                    break;
                case "13X18":
                    pricePerPicture = 0.38;
                    totalPrice = picturesAmount * pricePerPicture;
                    if (picturesAmount >= 50 && picturesAmount <= 100)
                    {
                        totalPrice -= totalPrice * 0.03;
                    }
                    else if (picturesAmount > 100)
                    {
                        totalPrice -= totalPrice * 0.05;
                    }
                    break;
                case "20X30":
                    pricePerPicture = 2.90;
                    totalPrice = picturesAmount * pricePerPicture;
                    if (picturesAmount >= 10 && picturesAmount <= 50)
                    {
                        totalPrice -= totalPrice * 0.07;
                    }
                    else if (picturesAmount > 50)
                    {
                        totalPrice -= totalPrice * 0.09;
                    }
                    break;
            }
            if (orderType == "online")
            {
                totalPrice -= totalPrice * 0.02;
            }
            Console.WriteLine($"{totalPrice:F2}BGN");
        }
    }
}
