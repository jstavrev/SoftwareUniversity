using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempC = double.Parse(Console.ReadLine());
            double tempF = tempC * 1.8 + 32;
            Console.WriteLine(tempF);
        }
    }
}
