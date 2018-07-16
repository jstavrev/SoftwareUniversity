using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceM = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            seconds += (hours * 3600) + (minutes * 60);

            double ms = (double)distanceM / seconds;
            double km = distanceM / 1000;
            double kmh = (double)km / ((double) seconds / 3600);
            double mph = ((double)distanceM / 1609 ) / ((double) seconds / 3600);

            Console.WriteLine("{0:0.######}", ms);
            Console.WriteLine("{0:0.######}", kmh);
            Console.WriteLine("{0:0.######}", mph);
        }
    }
}
