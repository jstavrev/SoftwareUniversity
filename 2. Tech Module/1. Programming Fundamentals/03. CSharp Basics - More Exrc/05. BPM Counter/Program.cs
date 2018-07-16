using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            double BPM = int.Parse(Console.ReadLine());
            int beatsNum = int.Parse(Console.ReadLine());

            double bars = Math.Round(beatsNum / 4.0, 1);
            double BPS = 60 / BPM;
            double sequenceLength = BPS * beatsNum;

            int seconds = (int)sequenceLength % 60;
            int minutes = (int)sequenceLength / 60;

            Console.WriteLine("{0} bars - {1}m {2}s", bars, minutes, seconds);
        }
    }
}
