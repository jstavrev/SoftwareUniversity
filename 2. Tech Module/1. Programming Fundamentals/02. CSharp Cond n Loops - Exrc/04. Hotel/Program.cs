using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsStaying = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;

            int nightsStayingStudio = nightsStaying;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    doublePrice = 65;
                    suitePrice = 75;
                    if (nightsStaying > 7)
                    {
                        studioPrice -= studioPrice * 0.05;
                    }
                    ; break;
                case "June":
                case "September":
                    studioPrice = 60;
                    doublePrice = 72;
                    suitePrice = 82;
                    if (nightsStaying > 14)
                    {
                        doublePrice -= doublePrice * 0.10;
                    }
                    ; break;
                case "July":
                case "August":
                case "December":
                    studioPrice = 68;
                    doublePrice = 77;
                    suitePrice = 89;
                    if (nightsStaying > 14)
                    {
                        suitePrice -= suitePrice * 0.15;
                    }
                    ; break;
            }
            if ((month == "September" || month == "October") && nightsStaying > 7)
            {
                nightsStayingStudio--;
            }

            Console.WriteLine("Studio: {0:0.00} lv.", studioPrice * nightsStayingStudio);
            Console.WriteLine("Double: {0:0.00} lv.", doublePrice * nightsStaying);
            Console.WriteLine("Suite: {0:0.00} lv.", suitePrice * nightsStaying);
        }
    }
}