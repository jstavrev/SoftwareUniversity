using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Voleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine(); // leap or normal year
            int holidaysAmount = int.Parse(Console.ReadLine()); // amount of holidays
            int homeTown = int.Parse(Console.ReadLine());    // amount of times person goes back to home town on weekends.

            double sofiaWeekends = 48 - homeTown;
            double sofiaVolley = sofiaWeekends * 3 / 4;
            double holidayVolley = holidaysAmount * 2.0 / 3;
            double totalVolley = sofiaVolley + holidayVolley + homeTown;

            switch (yearType)
            {
                case "normal": Console.WriteLine(Math.Truncate(totalVolley)); break;
                case "leap": Console.WriteLine(Math.Truncate(totalVolley + (totalVolley * 0.15))); break;
            }
        }
    }
}
