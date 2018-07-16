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
            int duljina = int.Parse(Console.ReadLine());
            int shirochina = int.Parse(Console.ReadLine());
            int visochina = int.Parse(Console.ReadLine());
            double percentageTaken = double.Parse(Console.ReadLine());

            int obem = duljina * shirochina * visochina;
            double totalL = obem * 0.001;

            percentageTaken *= 0.01;

            double result = totalL * (1 - percentageTaken);
            Console.WriteLine("{0:F3}", result);
        }
    }
}
