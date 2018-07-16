using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Supermarket_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<double, int>> stock = new Dictionary<string, Dictionary<double, int>>();
            string product;
            double price = 0.0;
            int quantity = 0;
            double grandTotal = 0;
            while (true)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();
                if (input[0] == "stocked")
                    break;

                product = input[0];
                price = double.Parse(input[1]);
                quantity = int.Parse(input[2]);

                if (stock.ContainsKey(product))
                {
                    if (stock[product].ContainsKey(price))
                        stock[product][price] += quantity;
                    else                    
                        stock[product][price] = quantity;                    
                }
                else
                {
                    Dictionary<double, int> assistDic = new Dictionary<double, int>();
                    assistDic.Add(price, quantity);
                    stock[product] = assistDic;
                }
            }
            foreach (var item in stock)
            {
                Console.Write($"{item.Key}: ");
                foreach (var pair in item.Value)
                {
                    if (item.Value.Count > 1)
                    {
                        double cost = item.Value.Keys.ElementAt(item.Value.Count - 1);
                        Console.WriteLine($"${cost:f2} * {item.Value.Values.Sum()} = ${cost * item.Value.Values.Sum():f2}");
                        grandTotal += cost * item.Value.Values.Sum();
                        break;
                    }
                    Console.WriteLine($"${pair.Key:f2} * {pair.Value} = ${pair.Key * pair.Value:f2}");
                    grandTotal += pair.Key * pair.Value;
                }
            }
            for (int i = 0; i < 30; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            Console.WriteLine($"Grand Total: ${grandTotal:f2}");
        }
    }
}
