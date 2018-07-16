using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Miles_To_Km
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());

            double km = miles * 1.60934;

            Console.WriteLine("{0:F2}", km);
        }
    }
}