using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Workout
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double totalKM = m;
            

            for (int i = 0; i < n; i++)
            {
                int k = int.Parse(Console.ReadLine());
                m += m * ((double)k / 100);
                totalKM += m;
            }
            if (totalKM >= 1000)
            {
                Console.WriteLine("You've done a great job running {0} more kilometers!", Math.Ceiling(totalKM - 1000));
            }
            else if (totalKM < 1000)
            {
                Console.WriteLine("Sorry Mrs. Ivanova, you need to run {0} more kilometers", Math.Ceiling(1000 - totalKM));
            }
        }
    }
}
