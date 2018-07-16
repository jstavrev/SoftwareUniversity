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

            int poor = 0;
            int satisfactory = 0;
            int good = 0;
            int veryGood = 0;
            int excellent = 0;
            for (int i = 0; i < n; i++)
            {
                double points = double.Parse(Console.ReadLine());
                if (points < 22.5)
                {
                    poor++;
                }
                else if (points >= 22.5 && points < 40.5)
                {
                    satisfactory++;
                }
                else if (points >= 40.5 && points < 58.5)
                {
                    good++;
                }
                else if (points >= 58.5 && points < 76.5)
                {
                    veryGood++;
                }
                else
                {
                    excellent++;
                }
            }
            double poorPercent = ((double)poor / n) * 100;
            double satisfactoryPercent = ((double)satisfactory / n) * 100;
            double goodPercent = ((double)good / n) * 100;
            double veryGoodPercent = ((double)veryGood / n) * 100;
            double excellentPercent = ((double)excellent / n) * 100;
            Console.WriteLine($"{poorPercent:F2}% poor marks");
            Console.WriteLine($"{satisfactoryPercent:F2}% satisfactory marks");
            Console.WriteLine($"{goodPercent:F2}% good marks");
            Console.WriteLine($"{veryGoodPercent:F2}% very good marks");
            Console.WriteLine($"{excellentPercent:F2}% excellent marks");
        }
    }
}
