﻿using System;


public class Program
{
    static void Main(string[] args)
    {
        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        try
        {
            Box box = new Box(length, width, height);

            Console.WriteLine($"Surface Area - {box.CalcSurfaceArea():F2}");
            Console.WriteLine($"Lateral Surface Area - {box.CalcLateralSurfaceArea():F2}");
            Console.WriteLine($"Volume - {box.CalcVolume():F2}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

