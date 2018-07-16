using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Num_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int count = 1;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("{0} ",count);
                    sum++;
                    count++;
                    if (sum == n)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (sum == n)
                {
                    break;
                }
            }
        }
    }
}
