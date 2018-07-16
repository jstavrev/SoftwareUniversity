using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            string animalType = Console.ReadLine();

            if (animalType == "dog" || animalType == "crocodile" || animalType == "tortoise" || animalType == "snake")
            {
                switch (animalType)
                {
                    case "dog": Console.WriteLine("mammal"); break;
                    case "crocodile": Console.WriteLine("reptile"); break;
                    case "tortoise": Console.WriteLine("reptile"); break;
                    case "snake": Console.WriteLine("reptile"); break;

                }
            }
           
            else
                Console.WriteLine("unknown");

        }
    }
}
