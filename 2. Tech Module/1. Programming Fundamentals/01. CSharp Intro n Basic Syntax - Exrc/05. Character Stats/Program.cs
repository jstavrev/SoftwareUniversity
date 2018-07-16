using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int healthCurrent = int.Parse(Console.ReadLine());
            int healthMax = int.Parse(Console.ReadLine());
            int energyCurrent = int.Parse(Console.ReadLine());
            int energyMax = int.Parse(Console.ReadLine());

            int healthDiff = healthMax - healthCurrent;
            int energyDiff = energyMax - energyCurrent;

            Console.WriteLine($"Name: {name}");
            Console.Write("Health: |");
            for (int i = 0; i < healthCurrent; i++)
            {
                Console.Write("|");
            }
            for (int i = 0; i < healthDiff; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine("|");
            Console.Write("Energy: |");
            for (int i = 0; i < energyCurrent; i++)
            {
                Console.Write("|");
            }
            for (int i = 0; i < energyDiff; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine("|");
        }
    }
}