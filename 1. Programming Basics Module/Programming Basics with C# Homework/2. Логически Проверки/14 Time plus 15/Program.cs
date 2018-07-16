using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication58
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            TimeSpan times = new TimeSpan(hour, minutes, 0);
            TimeSpan times2 = new TimeSpan(0, 15, 0);
            TimeSpan sumaTime = times + times2;

            Console.WriteLine("{0:h\\:mm}", sumaTime);
        }
    }
}