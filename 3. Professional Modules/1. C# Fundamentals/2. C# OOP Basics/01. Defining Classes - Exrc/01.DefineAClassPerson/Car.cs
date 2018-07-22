using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
    private string model;
    private double fuel;
    private double fuelPerKM;
    double distanceTraveled;

    public Car(string model, double fuel, double fuelPerKM)
    {
        this.Model = model;
        this.Fuel = fuel;
        this.FuelPerKM = fuelPerKM;
        this.DistanceTraveled = 0;
    }

    public string Model
    {
        get { return model; }
        set { this.model = value; }
    }

    public double Fuel
    {
        get { return fuel; }
        set { this.fuel = value; }
    }

    public double FuelPerKM
    {
        get { return fuelPerKM; }
        set { this.fuelPerKM = value; }
    }

    public double DistanceTraveled
    {
        get { return distanceTraveled; }
        set { this.distanceTraveled = value; }
    }

    public void CheckIfEnoughFuel(Car car, double distance)
    {
        bool enoughFuel = car.Fuel >= distance * car.FuelPerKM;
        if (enoughFuel)
        {
            car.MoveCar(car, distance);
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
        
    }

    public void MoveCar(Car car, double distance)
    {
        car.Fuel -= distance * car.FuelPerKM;
        car.DistanceTraveled += distance;
    }

}

