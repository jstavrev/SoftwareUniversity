using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string country1 = country.ToLower();

            if (country1 == "england" || country1 == "usa" || country1 == "spain" || country1 == "argentina" || country1 == "mexico")
            {
                switch (country1)
                {
                    case "england":
                        Console.WriteLine("English");
                        break;
                    case "usa":
                        Console.WriteLine("English");
                        break;
                    case "spain":
                        Console.WriteLine("Spanish");
                        break;
                    case "argentina":
                        Console.WriteLine("Spanish");
                        break;
                    case "mexico":
                        Console.WriteLine("Spanish");
                        break;
                }
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}