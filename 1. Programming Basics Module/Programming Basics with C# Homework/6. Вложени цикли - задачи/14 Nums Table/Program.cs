using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Nums_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int b = n;
            int x = (n + 1) - (n - 1);
            int d = n - 1;
            int z = n;

            if (n == 1)
            {
                Console.WriteLine(1);
            }

            else if (n == 2)
            {
                Console.WriteLine("1 2");
                Console.WriteLine("2 1");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();

                for (int i = 1; i <= n - 2; i++)
                {

                    for (int j = x; j <= n; j++)
                    {
                        Console.Write("{0} ", j);
                    }
                    x++;
                    for (int y = 1; y <= n - d; y++)
                    {
                        Console.Write("{0} ", z - 1);
                        z--;
                    }
                    d--;
                    z = n;
                    Console.WriteLine();
                }

                for (int i = 1; n >= i; n--)
                {
                    Console.Write("{0} ", n);
                }
                Console.WriteLine();
            }
        }
    }
}
