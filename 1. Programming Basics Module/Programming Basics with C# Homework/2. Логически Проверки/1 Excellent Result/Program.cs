using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Excellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            float grade = float.Parse(Console.ReadLine());
            if (grade > 5.49)
            {
                Console.WriteLine("Excellent!");
            }
         }
    }
}
