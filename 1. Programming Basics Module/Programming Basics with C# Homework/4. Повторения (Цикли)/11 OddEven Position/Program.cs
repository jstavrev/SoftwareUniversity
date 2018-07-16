using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OddEven_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double oddSum = 0.0;
            double evenSum = 0.0;

            double oddMax = -1000000000.0;
            double evenMax = -1000000000.0;

            double oddMin = 1000000000.0;
            double evenMin = 1000000000.0;

            double number = 0;



            if (n == 0)
            {
                Console.WriteLine("OddSum={0},", oddSum);
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");

                Console.WriteLine("EvenSum={0},", evenSum);
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }


            else
            {
                for (int i = 1; i <= n; i++)
                {
                    number = double.Parse(Console.ReadLine());

                    if (n == 1)
                    {
                        Console.WriteLine("OddSum={0},", number);
                        Console.WriteLine("OddMin={0},", number);
                        Console.WriteLine("OddMax={0},", number);

                        Console.WriteLine("EvenSum={0},", evenSum);
                        Console.WriteLine("EvenMin=No,");
                        Console.WriteLine("Evenmax=No");
                    }
                    else if (n > 1)
                    {

                        if (i % 2 == 0)
                        {
                            evenSum = evenSum + number;

                            if (number > evenMax)
                            {
                                evenMax = number;
                            }
                            if (number < evenMin)
                            {
                                evenMin = number;
                            }
                        }

                        else if (i % 2 != 0)
                        {
                            oddSum = oddSum + number;

                            if (number > oddMax)
                            {
                                oddMax = number;
                            }
                            if (number < oddMin)
                            {
                                oddMin = number;
                            }
                        }
                    }
                }
            }
            if (n > 1)
            {
                Console.WriteLine("OddSum={0},", oddSum);
                Console.WriteLine("OddMin={0},", oddMin);
                Console.WriteLine("OddMax={0},", oddMax);

                Console.WriteLine("EvenSum={0},", evenSum);
                Console.WriteLine("EvenMin={0},", evenMin);
                Console.WriteLine("EvenMax={0}", evenMax);
            }
        }
    }
}
