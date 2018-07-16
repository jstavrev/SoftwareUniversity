using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int[] arrayStart = new int[4];
            int[] arrayEnd = new int[4];

            for (int i = 0; i < 4; i++)
            {
                arrayEnd[i] = end % 10;
                end = end / 10;
            }

            for (int i = start; i <= end; i++)
            {
                int startNum = i;
                for (int y = 0; y < 4; y++)
                {
                    arrayStart[y] = startNum % 10;
                    startNum = startNum / 10;
                }

            }



        }
    }
}
