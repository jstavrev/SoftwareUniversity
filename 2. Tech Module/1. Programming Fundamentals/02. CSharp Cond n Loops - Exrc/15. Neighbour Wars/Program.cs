using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDmg = int.Parse(Console.ReadLine());
            int goshoDmg = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;

            int roundCounter = 0;

            while (true)
            {
                roundCounter++;
                goshoHealth -= peshoDmg;
                if (peshoHealth <= 0 || goshoHealth <= 0)
                {
                    break;
                }
                Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                if (roundCounter % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
                roundCounter++;
                peshoHealth -= goshoDmg;
                if (peshoHealth <= 0 || goshoHealth <= 0)
                {
                    break;
                }
                Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                if (roundCounter % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
            }
            if (peshoHealth <= 0)
            {
                Console.WriteLine($"Gosho won in {roundCounter}th round.");
            }
            else
            {
                Console.WriteLine($"Pesho won in {roundCounter}th round.");
            }
        }
    }
}