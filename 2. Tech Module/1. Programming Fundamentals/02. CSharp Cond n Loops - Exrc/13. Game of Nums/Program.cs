using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int jnzeNum = 0;
            int looper = 0;
            int num1 = 0;
            int num2 = 0;

            for (int i = n; i <= m; i++)        // Трябва да се измислят циклите, че да въртат всички възможни комбинации за интервала между две числа.
            {                                 // Останалата логика е вярна и работеща.
                for (int y = n; y <= m; y++)
                {
                    jnzeNum = i + y;
                    looper++;
                    if (jnzeNum == magicNum)
                    {
                        num1 = i;
                        num2 = y;
                    }
                }
            }
            if (num1 + num2 == magicNum)
            {
                Console.WriteLine($"Number found! {num1} + {num2} = {magicNum}");
            }
            else
            {
                Console.WriteLine($"{looper} combinations - neither equals {magicNum}");
            }

        }
    }
}