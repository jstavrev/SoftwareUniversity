using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber != 0 && inputNumber < 100 || inputNumber > 200)
            {
                Console.WriteLine("invalid");
            }
            
        }
    }
}
