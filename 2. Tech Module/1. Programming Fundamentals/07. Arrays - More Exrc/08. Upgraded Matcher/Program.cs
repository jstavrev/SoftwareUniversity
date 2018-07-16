using System;
using System.Linq;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ').ToArray();
            long[] quantity = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            int counter = 0;
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "done")
                {
                    break;
                }
                for (int i = 0; i < products.Length; i++)
                {
                    if (input[0] == products[i])
                    {
                        counter = i;
                        if (counter > quantity.Length - 1 || quantity[i] < long.Parse(input[1]))
                        {
                            Console.WriteLine($"We do not have enough {products[i]}");
                        }
                        else
                        {
                            Console.WriteLine("{0} x {1} costs {2:0.00}", products[i], input[1], long.Parse(input[1]) * price[i]);
                            quantity[i] -= long.Parse(input[1]);
                        }
                    }
                }
            }
        }
    }
}