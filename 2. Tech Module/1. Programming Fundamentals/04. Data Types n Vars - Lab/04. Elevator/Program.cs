using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            double trips = (double)peopleCount / elevatorCapacity;
            Console.WriteLine(Math.Ceiling(trips));
        }
    }
}
