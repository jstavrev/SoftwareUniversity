using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            switch (type)
            {
                case "Premiere": Console.WriteLine("{0:0.00} leva", rows * columns * 12); break;
                case "Normal": Console.WriteLine("{0:0.00} leva", rows * columns * 7.5); break;
                case "Discount": Console.WriteLine("{0:0.00} leva", rows * columns * 5); break;
            }
        }
    }
}
