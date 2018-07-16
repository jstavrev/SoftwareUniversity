using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            bool twelveDollars = (dayType == "Weekday" && ((age >= 0 && age <= 18) || (age > 64 && age <= 122))) || (dayType == "Holiday" && (age > 18 && age <= 64));
            bool fifteenDollars = dayType == "Weekend" && ((age >= 0 && age <= 18) || (age > 64 && age <= 122));

            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                if (twelveDollars)
                {
                    Console.WriteLine("12$");
                }
                else if (fifteenDollars)
                {
                    Console.WriteLine("15$");
                }
                else if (dayType == "Weekday" && (age > 18 && age <= 64))
                {
                    Console.WriteLine("18$");
                }
                else if (dayType == "Weekend" && (age > 18 && age <= 64))
                {
                    Console.WriteLine("20$");
                }
                else if (dayType == "Holiday" && (age >= 0 && age <= 18))
                {
                    Console.WriteLine("5$");
                }
                else
                {
                    Console.WriteLine("10$");
                }
            }
        }
    }
}