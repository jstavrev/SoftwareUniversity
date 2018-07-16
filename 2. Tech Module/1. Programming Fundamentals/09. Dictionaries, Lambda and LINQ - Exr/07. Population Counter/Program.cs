using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> populationStatistics = new Dictionary<string, Dictionary<string, long>>();
            string town;
            long population = 0;
            string country;
            while (true)
            {
                List<string> input = Console.ReadLine().Split('|').ToList();
                if (input[0] == "report")
                    break;
                town = input[0];
                country = input[1];
                population = long.Parse(input[2]);

                if (populationStatistics.ContainsKey(country))
                {
                        populationStatistics[country][town] = population;
                }
                else
                {
                    Dictionary<string, long> assistDic = new Dictionary<string, long>();
                    assistDic.Add(town, population);
                    populationStatistics.Add(country, assistDic);
                }
            }

            foreach (var nation in populationStatistics.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{nation.Key} (total population: {nation.Value.Values.Sum()})");
                foreach (var city in nation.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
