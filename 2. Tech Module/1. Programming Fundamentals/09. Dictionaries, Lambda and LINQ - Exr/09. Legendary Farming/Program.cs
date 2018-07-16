using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> farm = new Dictionary<string, int>();
            Dictionary<string, int> legendaryFarm = new Dictionary<string, int>();
            int shards = 0;
            int fragments = 0;
            int motes = 0;
            while (true)
            {
                if (shards >= 250 || fragments >= 250 || motes >= 250)
                    break;
                List<string> input = Console.ReadLine().ToLower().Split(' ').ToList();
                for (int i = 1; i < input.Count; i += 2)
                {
                    if (shards >= 250 || fragments >= 250 || motes >= 250)
                        break;

                    if (input[i] == "shards")
                        shards += int.Parse(input[i - 1]);
                    else if (input[i] == "fragments")
                        fragments += int.Parse(input[i - 1]);
                    else if (input[i] == "motes")
                        motes += int.Parse(input[i - 1]);

                    if (farm.ContainsKey(input[i]))
                        farm[input[i]] += int.Parse(input[i - 1]);
                    else if (input[i] != "shards" && input[i] != "fragments" && input[i] != "motes")
                        farm[input[i]] = int.Parse(input[i - 1]);
                }
            }
            if (shards >= 250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                shards -= 250;
            }
            else if (fragments >= 250)
            {
                Console.WriteLine("Valanyr obtained!");
                fragments -= 250;
            }
            else if (motes >= 250)
            {
                Console.WriteLine("Dragonwrath obtained!");
                motes -= 250;
            }

            legendaryFarm.Add("shards", shards);
            legendaryFarm.Add("fragments", fragments);
            legendaryFarm.Add("motes", motes);

            foreach (var item in legendaryFarm.OrderByDescending(x => x.Value).ThenBy(x => x.Key))           
                Console.WriteLine($"{item.Key}: {item.Value}");           
            foreach (var item in farm.OrderBy(x => x.Key))           
                Console.WriteLine($"{item.Key}: {item.Value}");           
        }
    }
}
