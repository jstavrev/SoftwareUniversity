using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, Car> cars = new Dictionary<string, Car>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string model = input[0];
            double fuel = double.Parse(input[1]);
            double fuelPerKM = double.Parse(input[2]);

            Car newCar = new Car(model, fuel, fuelPerKM);

            cars[model] = newCar;
        }

        while (true)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            if (input[0] == "End")
            {
                break;
            }
            string model = input[1];
            double distance = double.Parse(input[2]);

            cars[model].CheckIfEnoughFuel(cars[model], distance);
        }

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Value.Model} {car.Value.Fuel:F2} {car.Value.DistanceTraveled}");
        }
    }
}

