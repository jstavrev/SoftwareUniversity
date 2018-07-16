using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double rolkiHartiq = double.Parse(Console.ReadLine());
            double rolkiPlat = double.Parse(Console.ReadLine());
            double lepiloL = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double moneyReq = rolkiHartiq * 5.8 + rolkiPlat * 7.2 + lepiloL * 1.2;
            moneyReq = moneyReq - ((moneyReq * discount) / 100);
            Console.WriteLine($"{moneyReq:F3}");
        }
    }
}
