using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Five_Diff_Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (Math.Abs(a - b) < 5)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    for (int y = a; y <= b; y++)
                    {
                        for (int j = a; j <= b; j++)
                        {
                            for (int k = a; k <= b; k++)
                            {
                                for (int l = a; l <= b; l++)
                                {

                                    if (y <= i || j <= y || k <= j || l <= k)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{i} {y} {j} {k} {l}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}