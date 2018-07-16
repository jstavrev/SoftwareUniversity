using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double powerBill = 0.0;
            double otherBills = 0.0;
            for (int i = 0; i < months; i++)
            {
                double bill = double.Parse(Console.ReadLine());
                powerBill += bill;
                double other = (20 + 15 + bill) + ((20 + 15 + bill) * 0.2);
                otherBills += other;
            }
            double waterBill = months * 20;
            double inetBill = months * 15;
            double avrg = (powerBill + otherBills + waterBill + inetBill) / months;

            Console.WriteLine($"Electricity: {powerBill:F2} lv");
            Console.WriteLine($"Water: {waterBill:F2} lv");
            Console.WriteLine($"Internet: {inetBill:F2} lv");
            Console.WriteLine($"Other: {otherBills:F2} lv");
            Console.WriteLine($"Average: {avrg:F2} lv");
        }
    }
}
