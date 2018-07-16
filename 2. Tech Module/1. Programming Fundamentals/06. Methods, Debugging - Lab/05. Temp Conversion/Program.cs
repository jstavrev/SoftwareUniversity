using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Temp_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheitT = double.Parse(Console.ReadLine());
            double celsiusT = ConverseFahrenheitToC(fahrenheitT);
            Console.WriteLine($"{celsiusT:F2}");
        }

        static double ConverseFahrenheitToC(double fahrenheitT)
        {
            return (fahrenheitT - 32) * 5 / 9;
        }
    }
}
