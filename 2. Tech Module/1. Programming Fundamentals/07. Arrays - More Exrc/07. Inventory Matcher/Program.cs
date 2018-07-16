using System;
using System.Linq;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ').ToArray();
            long[] quantity = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "done")
                {
                    break;
                }
                for (int i = 0; i < products.Length; i++)
                {
                    if (input == products[i])
                    {
                        Console.WriteLine("{0} costs: {1}; Available quantity: {2}", products[i], price[i], quantity[i]);
                    }
                }
            }
        }
    }
}