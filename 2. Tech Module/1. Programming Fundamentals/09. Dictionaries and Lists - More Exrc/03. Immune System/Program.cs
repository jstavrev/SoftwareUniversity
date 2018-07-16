using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Immune_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = int.Parse(Console.ReadLine());
            int initialHealth = health;
            int virusStrength = 0;
            int timeToDefeat = 0;
            Dictionary<string, int> virusOccurrences = new Dictionary<string, int>();

            while (true)
            {
                if (health <= 0)
                    break;
                string virus = Console.ReadLine();
                if (virus == "end")
                    break;

                if (virusOccurrences.ContainsKey(virus))
                    virusOccurrences[virus]++;
                else
                    virusOccurrences[virus] = 1;

                if (virusOccurrences[virus] < 2)
                {
                    for (int i = 0; i < virus.Length; i++)
                    {
                        virusStrength += virus[i];
                    }
                    timeToDefeat = (virusStrength / 3) * virus.Length;
                    TimeSpan time = TimeSpan.FromSeconds(timeToDefeat);
                    string text = time.ToString(@"m\:s");
                    List<int> timeList = text.Split(':').Select(int.Parse).ToList();
                    if (timeToDefeat > 3600)
                    {
                        timeList[0] += 60;
                    }
                    Console.WriteLine($"Virus {virus}: {virusStrength / 3} => {timeToDefeat} seconds");
                    if (health - timeToDefeat > 0 )
                    {
                        Console.WriteLine($"{virus} defeated in {timeList[0]}m {timeList[1]}s.");
                        health -= timeToDefeat;
                        Console.WriteLine($"Remaining health: {health}");
                        if (health + (health * 0.2) > initialHealth)
                        {
                            health = initialHealth;
                        }
                        else
                            health = health + (int)(health * 0.2);
                    }
                    else
                    {
                        health -= timeToDefeat;
                        break;
                    }
                }
                else
                {
                    for (int i = 0; i < virus.Length; i++)
                    {
                        virusStrength += virus[i];
                    }
                    timeToDefeat = ((virusStrength / 3) * virus.Length) / 3;
                    TimeSpan time = TimeSpan.FromSeconds(timeToDefeat);
                    string text = time.ToString(@"m\:s");
                    List<int> timeList = text.Split(':').Select(int.Parse).ToList();
                    Console.WriteLine($"Virus {virus}: {virusStrength / 3} => {timeToDefeat} seconds");
                    if (health - timeToDefeat > 0)
                    {
                        Console.WriteLine($"{virus} defeated in {timeList[0]}m {timeList[1]}s.");
                        health -= timeToDefeat;
                        Console.WriteLine($"Remaining health: {health}");
                        if (health + (health * 0.2) > initialHealth)
                        {
                            health = initialHealth;
                        }
                        else
                            health = health + (int)(health * 0.2);
                    }
                    else
                    {
                        health -= timeToDefeat;
                        break;
                    }
                }
                virusStrength = 0;
                timeToDefeat = 0;
            }
            if (health > 0)
                Console.WriteLine($"Final Health: {health}");
            else
                Console.WriteLine($"Immune System Defeated.");
        }
    }
}
