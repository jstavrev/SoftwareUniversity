using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            int num = Convert.ToInt32(n, 16);
            Console.WriteLine(num);
        }
    }
}
