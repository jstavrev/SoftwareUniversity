using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperialUnit = Console.ReadLine();
            double distance = double.Parse(Console.ReadLine());

            double result = 0.0;
            switch (imperialUnit)
            {
                case "miles":
                    result = distance * 1.6;
                    Console.WriteLine($"{distance} {imperialUnit} = {result:F2} kilometers");
                    break;
                case "inches":
                    result = distance * 2.54;
                    Console.WriteLine($"{distance} {imperialUnit} = {result:F2} centimeters");
                    break;
                case "feet":
                    result = distance * 30;
                    Console.WriteLine($"{distance} {imperialUnit} = {result:F2} centimeters");
                    break;
                case "yards":
                    result = distance * 0.91;
                    Console.WriteLine($"{distance} {imperialUnit} = {result:F2} meters");
                    break;
                case "gallons":
                    result = distance * 3.8;
                    Console.WriteLine($"{distance} {imperialUnit} = {result:F2} liters");
                    break;


            }
        }
    }
}
