using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());
            var seconds = time1 + time2 + time3;
            var mins = 0.0;
            if (seconds >= 120)
            {
                mins++; mins++; seconds = seconds - 120;
            }
            else if (seconds >= 60)
            {
                mins++; seconds = seconds - 60;
            }

            if (seconds < 10)
            {
                Console.WriteLine("{0}:0{1}", mins, seconds);
            }
            else
            {
                Console.WriteLine("{0}:{1}", mins, seconds);
            }
        }
    }
}
