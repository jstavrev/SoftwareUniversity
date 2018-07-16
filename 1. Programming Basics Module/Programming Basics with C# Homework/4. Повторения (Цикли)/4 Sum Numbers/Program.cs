using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalSum = 0;
            for (int i = 0; i < n; i++)
            {
                int sum = int.Parse(Console.ReadLine());
                totalSum = totalSum + sum;
            }
            Console.WriteLine(totalSum);
        }
    }
}
