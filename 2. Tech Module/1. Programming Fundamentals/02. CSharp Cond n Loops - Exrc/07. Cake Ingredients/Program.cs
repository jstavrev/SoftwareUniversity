using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();

            int sum = 0;

            while (true)
            {
                if (ingredient == "Bake!")
                {
                    Console.WriteLine("Preparing cake with {0} ingredients.", sum);
                    break;
                }
                else
                {
                    Console.WriteLine("Adding ingredient {0}.", ingredient);
                    sum++;
                    ingredient = Console.ReadLine();
                }

            }
        }
    }
}