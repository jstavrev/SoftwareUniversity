using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = Console.ReadLine();
            //string[] arr = str.Split(' ');

            //string[] arrReverse = arr;
            //Array.Reverse(arrReverse);
            //for (int i = 0; i < arrReverse.Length; i++)
            //{
            //    Console.Write($"{arrReverse[i]} ");
            //}
            ////Console.WriteLine();

            string[] arr = Console.ReadLine().Split(' ');
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
    }
}
