using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            try
            {
                while (true)
                {
                    int n = int.Parse(Console.ReadLine());
                    sum++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(sum);
            }
        }
    }
}