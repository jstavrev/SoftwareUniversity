using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputNumber = double.Parse(Console.ReadLine());
            string currency1 = Console.ReadLine();
            string outputCurrency = Console.ReadLine();

            if (currency1 == "BGN")
            {
                if (outputCurrency == "USD")
                {
                    double result = inputNumber / 1.79549;
                    Console.WriteLine(result);
                    Console.WriteLine("Press ENTER to exit.");
                    Console.ReadLine();
                }
                else if (outputCurrency == "EUR")
                {
                    double result = inputNumber / 1.95583;
                    Console.WriteLine(result);
                }
                else if (outputCurrency == "GBP")
                {
                    double result = inputNumber / 2.53405;
                    Console.WriteLine(result);
                }

                else if (outputCurrency == "BGN")
                {
                    double result = inputNumber * 1;
                    Console.WriteLine(result);
                }
            }

            if (currency1 == "GBP")
            {
                if (outputCurrency == "USD")
                {
                    double toBGN = inputNumber * 2.53405;
                    double result = toBGN / 1.79549;
                    Console.WriteLine(result);
                }
                else if (outputCurrency == "EUR")
                {
                    double toBGN = inputNumber * 2.53405;
                    double result = toBGN / 1.95583;
                    Console.WriteLine(result);
                }
                else if (outputCurrency == "BGN")
                {
                    
                    double result = inputNumber * 2.53405;
                    Console.WriteLine(result);
                }

                else if (outputCurrency == "GBP")
                {
                    
                    double result = inputNumber * 1;
                    Console.WriteLine(result);
                }
            }

            if (currency1 == "USD")
            {
                if (outputCurrency == "BGN")
                {
                    
                    double result = inputNumber * 1.79549;
                    Console.WriteLine(result);
                }
                else if (outputCurrency == "EUR")
                {
                    double toBGN = inputNumber * 1.79549;
                    double result = toBGN / 1.95583;
                    Console.WriteLine(result);
                }
                else if (outputCurrency == "GBP")
                {
                    double toBGN = inputNumber * 1.79549;
                    double result = toBGN / 2.53405;
                    Console.WriteLine(result);
                }

                else if (outputCurrency == "USD")
                {
                    
                    double result = inputNumber * 1;
                    Console.WriteLine(result);
                }
            }

            if (currency1 == "EUR")
            {
                if (outputCurrency == "USD")
                {
                    double toBGN = inputNumber * 1.95583;
                    double result = toBGN / 1.79549;
                    Console.WriteLine(result);
                }
                else if (outputCurrency == "BGN")
                {
                    double result = inputNumber * 1.95583;
                    Console.WriteLine(result);
                }
                else if (outputCurrency == "GBP")
                {
                    double toBGN = inputNumber * 1.95583;
                    double result = toBGN / 2.53405;
                    Console.WriteLine(result);
                }

                else if (outputCurrency == "EUR")
                {
                    
                    double result = inputNumber * 1;
                    Console.WriteLine(result);
                }
            }

            // Върти EUR/USD/GBP през BGN, че да можеш да ги конвъртнеш.

        }
    }
}
