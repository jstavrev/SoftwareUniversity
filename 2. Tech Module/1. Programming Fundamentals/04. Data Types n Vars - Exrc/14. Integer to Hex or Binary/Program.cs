using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_to_Hex_or_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string myHex = n.ToString("X");
            string myBin = Convert.ToString(n, 2);
            Console.WriteLine(myHex);
            Console.WriteLine(myBin);
        }
    }
}
