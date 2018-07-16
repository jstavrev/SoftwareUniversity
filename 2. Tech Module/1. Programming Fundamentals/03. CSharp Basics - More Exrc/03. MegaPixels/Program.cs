namespace _2.Vapor_Store
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double pixels = width * height;

            Console.WriteLine($"{width}x{height} => {Math.Round(pixels / 1000000, 1)}MP");
        }
    }
}