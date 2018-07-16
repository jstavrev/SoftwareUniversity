using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            while (true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());
                if (resources.ContainsKey(resource))
                {
                    resources[resource] += quantity;
                }
                else
                {
                    resources[resource] = quantity;
                }
            }
            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
