using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            string inputMetric = Console.ReadLine();
            string outputMetric = Console.ReadLine();

            if (inputMetric == "m")
            {
                if (outputMetric == "mm")
                {
                    var result = number * 1000;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "cm")
                {
                    double result = number * 100;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "mi")
                {
                    double result = number * 0.000621371192;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "in")
                {
                    double result = number * 39.3700787;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "km")
                {
                    double result = number * 0.001;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "ft")
                {
                    double result = number * 3.2808399;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "yd")
                {
                    double result = number * 1.0936133;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "m")
                {
                    double result = number * 1;
                    Console.WriteLine(Math.Round(result, 8));
                }
            }


            if (inputMetric == "mm")
            {
                if (outputMetric == "cm")
                {
                    double result = number * 0.1;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "mi")
                {
                    double result = number * 0.000000621371192;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "in")
                {
                    double result = number * 0.0393700787;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "km")
                {
                    double result = number * 0.000001;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "ft")
                {
                    double result = number * 0.0032808399;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "yd")
                {
                    double result = number * 0.0010936133;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "mm")
                {
                    double result = number * 1;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "m")
                {
                    double result = number / 1000;
                    Console.WriteLine(Math.Round(result, 8));
                }
            }


            if (inputMetric == "cm")
            {
                if (outputMetric == "mi")
                {
                    double result = number * 0.00000621371192;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "in")
                {
                    double result = number * 0.393700787;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "km")
                {
                    double result = number * 0.00001;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "ft")
                {
                    double result = number * 0.032808399;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "yd")
                {
                    double result = number * 0.010936133;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "cm")
                {
                    double result = number * 1;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "m")
                {
                    double result = number / 100;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "mm")
                {
                    double result = number * 10;
                    Console.WriteLine(Math.Round(result, 8));
                }

            }


            if (inputMetric == "mi")
            {
                if (outputMetric == "in")
                {
                    double result = number * 63360;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "km")
                {
                    double result = number * 1.60934;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "ft")
                {
                    double result = number * 5280;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "yd")
                {
                    double result = number * 1760;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "m")
                {
                    double result = number * 1609.344;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "mi")
                {
                    double result = number * 1;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "cm")
                {
                    double result = number * 160934.40;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "mm")
                {
                    double result = number * 1609344;
                    Console.WriteLine(Math.Round(result, 8));
                }
            }


            if (inputMetric == "in")
            {
                if (outputMetric == "km")
                {
                    double result = number * 2.54e-5;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "ft")
                {
                    double result = number * 0.0833333;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "yd")
                {
                    double result = number * 0.0277778;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "m")
                {
                    double result = number * 0.0254;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "mm")
                {
                    double result = number * 25.4;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "cm")
                {
                    double result = number * 2.54;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "mi")
                {
                    double result = number * 1.57828e-5;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "in")
                {
                    double result = number * 1;
                    Console.WriteLine(Math.Round(result, 8));
                }
            }


            if (inputMetric == "km")
            {
                if (outputMetric == "ft")
                {
                    double result = number * 3280.839895;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "yd")
                {
                    double result = number * 1093.613298;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "m")
                {
                    double result = number * 1000;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "mm")
                {
                    double result = number * 1000000;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "cm")
                {
                    double result = number * 100000;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "mi")
                {
                    double result = number * 0.621371;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "in")
                {
                    double result = number * 39370.08;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "km")
                {
                    double result = number * 1;
                    Console.WriteLine(Math.Round(result, 8));
                }
            }
            if (inputMetric == "ft")
            {
                if (outputMetric == "yd")
                {
                    double result = number * 0.333333;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "m")
                {
                    double result = number * 0.3048;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "mm")
                {
                    double result = number * 304.8;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "cm")
                {
                    double result = number * 30.48;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "in")
                {
                    double result = number * 12;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "mi")
                {
                    double result = number * 0.000189394;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "ft")
                {
                    double result = number * 1;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "km")
                {
                    double result = number * 0.0003048;
                    Console.WriteLine(Math.Round(result, 8));
                }
            }

            if (inputMetric == "yd")
            {
                if (outputMetric == "yd")
                {
                    double result = number * 1;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "m")
                {
                    double result = number * 0.9144;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "mm")
                {
                    double result = number * 914.4;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "cm")
                {
                    double result = number * 91.44;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "in")
                {
                    double result = number * 36;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "mi")
                {
                    double result = number * 0.000568182;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "ft")
                {
                    double result = number * 3;
                    Console.WriteLine(Math.Round(result, 8));
                }
                else if (outputMetric == "km")
                {
                    double result = number * 0.0009144;
                    Console.WriteLine(Math.Round(result, 8));
                }
            }
        }
    }
}