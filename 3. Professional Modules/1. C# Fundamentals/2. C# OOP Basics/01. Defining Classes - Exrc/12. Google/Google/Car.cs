using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
    private string carModel;
    private int carSpeed;

    public Car(string carModel, int carSpeed)
    {
        this.CarModel = carModel;
        this.CarSpeed = carSpeed;
    }

    public int CarSpeed
    {
        get { return carSpeed; }
        set { carSpeed = value; }
    }

    public string CarModel
    {
        get { return carModel; }
        set { carModel = value; }
    }
}

