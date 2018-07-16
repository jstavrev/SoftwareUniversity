using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double reward = double.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int part = int.Parse(Console.ReadLine());
                if (i % 2 == 0 && i != 1)
                {
                    part = part * 2;
                }

                sum += part;
            }
            Console.WriteLine("The project prize was {0:F2} lv.", sum * reward);
        }
    }
}
