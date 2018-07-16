using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());

            double ivanchoTime = distance * secondsPerMeter;
            double a = Math.Floor((distance / 15)) * 12.5;
            ivanchoTime += a;

            if (record <= ivanchoTime)
            {
                Console.WriteLine("No, he failed! He was {0:F2} seconds slower.", Math.Abs(record - ivanchoTime));
            }
            else
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:F2} seconds.", ivanchoTime);
            }
        }
    }
}
