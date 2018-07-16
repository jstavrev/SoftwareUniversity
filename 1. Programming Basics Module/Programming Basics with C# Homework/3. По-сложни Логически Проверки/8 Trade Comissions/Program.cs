using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string townLoc = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());

            double comissions = 0.0;

            if (sales < 0 || townLoc != "sofia" && townLoc != "varna" && townLoc != "plovdiv")
                
            {
                Console.WriteLine("error");
            }

            else if ( townLoc == "sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comissions = sales * 0.05;
                    Console.WriteLine("{0:0.00}", Math.Round(comissions, 2));
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comissions = sales * 0.07;
                    Console.WriteLine("{0:0.00}", Math.Round(comissions, 2));
                }
                else if(sales > 1000 && sales <= 10000)
                {
                    comissions = sales * 0.08;
                    Console.WriteLine("{0:0.00}", Math.Round(comissions, 2));
                }
                else if(sales > 10000)
                {
                    comissions = sales * 0.12;
                    Console.WriteLine("{0:0.00}", Math.Round(comissions, 2));
                }
            }

            else if (townLoc == "varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comissions = sales * 0.045;
                    Console.WriteLine("{0:0.00}", Math.Round(comissions, 2));
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comissions = sales * 0.075;
                    Console.WriteLine("{0:0.00}", Math.Round(comissions, 2));
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comissions = sales * 0.1;
                    Console.WriteLine("{0:0.00}", Math.Round(comissions, 2));
                }
                else if (sales > 10000)
                {
                    comissions = sales * 0.13;
                    Console.WriteLine("{0:0.00}", Math.Round(comissions, 2));
                }
            }

            else if (townLoc == "plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comissions = sales * 0.055;
                    Console.WriteLine("{0:0.00}", Math.Round(comissions, 2));
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comissions = sales * 0.08;
                    Console.WriteLine("{0:0.00}", Math.Round(comissions, 2));
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comissions = sales * 0.12;
                    Console.WriteLine("{0:0.00}", Math.Round(comissions, 2));
                }
                else if (sales > 10000)
                {
                    comissions = sales * 0.145;
                    Console.WriteLine("{0:0.00}", Math.Round(comissions, 2));
                }
            }
        }
    }
}
