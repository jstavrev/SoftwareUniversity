using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = n;
            int leftTotal = 0;
            int rightTotal = 0;

            for (int i = 0; i < n; i++)
            {
                int leftSide = int.Parse(Console.ReadLine());
                leftTotal = leftTotal + leftSide;
            }

            for (int i = 0; i < n1; i++)
            {
                int rightSide = int.Parse(Console.ReadLine());
                rightTotal = rightTotal + rightSide;
            }

            if (leftTotal == rightTotal)
            {
                Console.WriteLine("Yes, sum = {0}", leftTotal);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(leftTotal - rightTotal));
            }

        }
    }
}
