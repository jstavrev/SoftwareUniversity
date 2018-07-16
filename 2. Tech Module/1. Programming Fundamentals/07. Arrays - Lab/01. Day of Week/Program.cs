using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[] { "Invalid Day!", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine(days[1]);
                    break;
                case 2:
                    Console.WriteLine(days[2]);
                    break;
                case 3:
                    Console.WriteLine(days[3]);
                    break;
                case 4:
                    Console.WriteLine(days[4]);
                    break;
                case 5:
                    Console.WriteLine(days[5]);
                    break;
                case 6:
                    Console.WriteLine(days[6]);
                    break;
                case 7:
                    Console.WriteLine(days[7]);
                    break;
                default:
                    Console.WriteLine(days[0]);
                    break;
            }
        }
    }
}
