using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNum = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double photoSize = double.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: DSC_{0:0000}.jpg", photoNum);
            Console.WriteLine("Date Taken: {0:00}/{1:00}/{2:0000} {3:00}:{4:00}", day, month, year, hours, minutes);
            if (photoSize < 1000)
            {
                Console.WriteLine("Size: {0}B", photoSize);
            }
            else if (photoSize > 1000 && photoSize < 1000000)
            {
                Console.WriteLine("Size: {0}KB", photoSize / 1000);
            }
            else
            {
                Console.WriteLine("Size: {0}MB", photoSize / 1000000);
            }
            if (width > height)
            {
                Console.WriteLine("Resolution: {0}x{1} (landscape)", width, height);
            }
            else if (height > width)
            {
                Console.WriteLine("Resolution: {0}x{1} (portrait)", width, height);
            }
            else
            {
                Console.WriteLine("Resolution: {0}x{1} (square)", width, height);
            }           
        }
    }
}
