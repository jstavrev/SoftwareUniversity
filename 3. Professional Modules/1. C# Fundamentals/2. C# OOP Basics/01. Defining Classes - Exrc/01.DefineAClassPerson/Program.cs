using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
        List<Car> cars = new List<Car>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] inputEngine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string model = inputEngine[0];
            int power = int.Parse(inputEngine[1]);
            int displacement = 0;
            string efficiency = "n/a";

            if (inputEngine.Length == 3)
            {
                bool isNum = int.TryParse(inputEngine[2], out displacement);
                if (!isNum)
                {
                    efficiency = inputEngine[2];
                }
            }
            else if (inputEngine.Length == 4)
            {
                displacement = int.Parse(inputEngine[2]);
                efficiency = inputEngine[3];
            }
            Engine newEngine = new Engine(model, power, displacement, efficiency);
            engines[model] = newEngine;
        }

        int m = int.Parse(Console.ReadLine());
        for (int i = 0; i < m; i++)
        {
            string[] carInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string model = carInput[0];
            string engine = carInput[1];
            int weight = 0;
            string color = "n/a";

            if (carInput.Length == 3)
            {
                bool isNum = int.TryParse(carInput[2], out weight);

                if (!isNum)
                {
                    color = carInput[2];
                }
            }
            else if (carInput.Length == 4)
            {
                weight = int.Parse(carInput[2]);
                color = carInput[3];
            }
            Car newCar = new Car(model, engines[engine], weight, color);
            cars.Add(newCar);
        }

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Model}:");
            Console.WriteLine($" {car.Engine.Model}:");
            Console.WriteLine($"  Power: {car.Engine.Power}");
            if (car.Engine.Displacement == 0)
            {
                Console.WriteLine($"  Displacement: n/a");
            }
            else
            {
                Console.WriteLine($"  Displacement: {car.Engine.Displacement}");
            }
            Console.WriteLine($"  Efficiency: {car.Engine.Efficiency}");
            if (car.Weight == 0)
            {
                Console.WriteLine($" Weight: n/a");
            }
            else
            {
                Console.WriteLine($" Weight: {car.Weight}");
            }
            Console.WriteLine($" Color: {car.Color}");
        }
    }
}

