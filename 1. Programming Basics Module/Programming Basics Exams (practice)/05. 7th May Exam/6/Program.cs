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
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int specialNum = int.Parse(Console.ReadLine());
            int controlNum = int.Parse(Console.ReadLine());

            for (int i = m; i >= 1; i--)
            {
                if (specialNum >= controlNum)
                {
                    break;
                }
                for (int y = n; y >= 1; y--)
                {
                    if (specialNum >= controlNum)
                    {
                        break;
                    }
                    for (int j = l; j >= 1; j--)
                    {
                        int mnl = (i * 100) + (y * 10) + j;
                        if (specialNum >= controlNum)
                        {
                            break;
                        }
                        if (mnl % 3 == 0)
                        {
                            specialNum += 5;
                        }
                        else if (mnl % 10 == 5)
                        {
                            specialNum -= 2;
                        }
                        else if (mnl % 2 == 0)
                        {
                            specialNum *= 2;
                        }
                    }
                }
            }
            if (specialNum >= controlNum)
            {
                Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNum}.");

            }
            else
            {
                Console.WriteLine($"No! {specialNum} is the last reached special number.");
            }
        }
    }
}
