using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.softuni_zadachi___Чертане_с_цикли
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = new string ('*', 10);


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(text);
            }
        }
    }
}
