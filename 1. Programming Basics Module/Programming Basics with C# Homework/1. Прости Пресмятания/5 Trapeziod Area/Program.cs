using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Trapeziod_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            float b1 = float.Parse(Console.ReadLine());
            float b2 = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());

            float area = (b1 + b2) * height / 2;

            Console.WriteLine("Liceto e: {0}", area);

        }
    }
}
