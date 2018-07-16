using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            float webHeight = float.Parse(Console.ReadLine());
            float price = float.Parse(Console.ReadLine());
            float weight = float.Parse(Console.ReadLine());

            int webVolume = (length * 2) + (width * 2);
            float totalPrice = webVolume * price;
            float webSpacing = webHeight * webVolume;
            float webWeight = webSpacing * weight;

            Console.WriteLine(webVolume);
            Console.WriteLine($"{totalPrice:F2}");
            Console.WriteLine($"{webWeight:F3}");
        }
    }
}
