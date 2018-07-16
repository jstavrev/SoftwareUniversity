using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Vuvedete A:");
            int a = int.Parse(Console.ReadLine());
            int area = a * a;
            Console.WriteLine("Liceto na kvadrata e: {0}", area);
        }
    }
}
