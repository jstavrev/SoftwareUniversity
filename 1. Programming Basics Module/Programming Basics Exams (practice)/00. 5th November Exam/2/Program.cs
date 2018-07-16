using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            float tomatoesKG = float.Parse(Console.ReadLine());
            int kasetki = int.Parse(Console.ReadLine());
            int burkani = int.Parse(Console.ReadLine());

            double lutenica = tomatoesKG / 5;
            int intLutenica = (int)lutenica;
            double burkaniNeeded = lutenica / 0.535;
            double kasetiNeeded = burkaniNeeded / burkani;

            if (kasetiNeeded >= kasetki)
            {
                double kasetkiLeft = Math.Floor(kasetiNeeded - kasetki);
                double burkaniLeft = Math.Floor(burkaniNeeded - (kasetki * burkani));

                Console.WriteLine($"Total lutenica: {intLutenica} kilograms.");
                Console.WriteLine($"{kasetkiLeft} boxes left.");
                Console.WriteLine($"{burkaniLeft} jars left.");
            }
            else
            {
                double kasetkiLeft = Math.Floor(Math.Abs((kasetiNeeded - kasetki)));
                double burkaniLeft = Math.Floor(Math.Abs((burkaniNeeded - (kasetki * burkani))));
                Console.WriteLine($"Total lutenica: {intLutenica} kilograms.");
                Console.WriteLine($"{kasetkiLeft} more boxes needed.");
                Console.WriteLine($"{burkaniLeft} more jars needed.");
            }
        }
    }
}
