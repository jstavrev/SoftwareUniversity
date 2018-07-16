using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            for (int i = 1; i <= n; i++)
            {
                CheckIsMaster(i);               
            }
        }

        private static void CheckIsMaster(int i)
        {
            bool isSymm = false;
            bool DivBySeven = false;
            bool OneEvenDigit = false;

            int num = i;
            int rev = 0;
            while (num > 0)
            {
                int dig = num % 10;
                rev = rev * 10 + dig;
                num = num / 10;
            }
            if (i == rev)
            {
                isSymm = true;
            }

            int digitsAmount = 0;
            if (i < 10)
            {
                digitsAmount = 1;
            }
            else if (i < 100)
            {
                digitsAmount = 2;
            }
            else if (i < 1000)
            {
                digitsAmount = 3;
            }
            else if (i < 10000)
            {
                digitsAmount = 4;
            }
            else
            {
                digitsAmount = 5;
            }
            int digitSum = 0;
            int numz = i;
            for (int y = 1; y <= digitsAmount; y++)
            {
                digitSum += numz % 10;
                numz = numz / 10;
            }
            if (digitSum % 7 == 0)
            {
                DivBySeven = true;
            }
            int nums = i;
            for (int j = 1; j <= digitsAmount; j++)
            {
                int z = nums % 10;
                if (z % 2 == 0)
                {
                    OneEvenDigit = true;
                    break;
                }
                nums = nums / 10;
            }
            if (isSymm && OneEvenDigit && DivBySeven)
            {
                Console.WriteLine(i);
            }
        }
    }
}
