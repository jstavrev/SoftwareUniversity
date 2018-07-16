using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Inches_to_cm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete chislo:");
            double inch = double.Parse(Console.ReadLine());

            double cm = inch * 2.54;

            Console.WriteLine("Chisloto v cantimetri e = {0}", cm);





        }
    }
}
