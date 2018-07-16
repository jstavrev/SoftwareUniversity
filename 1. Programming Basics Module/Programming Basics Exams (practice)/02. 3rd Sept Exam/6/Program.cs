using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int OneBGNCoinsAmount = int.Parse(Console.ReadLine());
            int TwoBGNCoinsAmount = int.Parse(Console.ReadLine());
            int FiveBGNBillsAmount = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= OneBGNCoinsAmount; i++)
            {
                for (int y = 0; y <= TwoBGNCoinsAmount; y++)
                {
                    for (int j = 0; j <= FiveBGNBillsAmount; j++)
                    {
                        if (i * 1 + y * 2 + j * 5 == sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {y} * 2 lv. + {j} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
