using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _08.House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            string price = Console.ReadLine();
            string price2 = Console.ReadLine();

            long totalPrice = 0;
            if (sbyte.TryParse(price, out sbyte priceTry))
            {
                sbyte.TryParse(price, out sbyte sbytePrice);
                int.TryParse(price2, out int intPrice);
                totalPrice = (sbytePrice * 4) + (intPrice * 10);
            }
            else if (sbyte.TryParse(price2, out sbyte priceTry2))
            {
                sbyte.TryParse(price2, out sbyte sbytePrice);
                int.TryParse(price, out int intPrice);
                totalPrice = (sbytePrice * 4) + ((long)intPrice * 10);
            }
            Console.WriteLine(totalPrice);
        }
    }
}
