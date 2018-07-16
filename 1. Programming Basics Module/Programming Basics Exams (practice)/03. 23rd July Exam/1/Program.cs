using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double wardrobeA = double.Parse(Console.ReadLine());

            double totalSize = (length * width - (Math.Pow(wardrobeA, 2)) - ((length * width) / 10)) * 10000;
            double dancersAmount = Math.Floor(totalSize / 7040);
            Console.WriteLine(dancersAmount);




        }
    }
}
