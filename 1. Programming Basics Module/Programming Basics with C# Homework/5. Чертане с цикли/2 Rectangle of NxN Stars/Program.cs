using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Rectangle_of_NxN_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string text = new string('*', n);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(text);
            }
        }
    }
}
