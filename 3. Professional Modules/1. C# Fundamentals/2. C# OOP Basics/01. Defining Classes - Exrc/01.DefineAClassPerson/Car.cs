using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
    private string model;
    private Engine engine;
    private int weight;
    private string color;

    public Car(string model, Engine engine, int weight, string color)
    {
        this.Model = model;
        this.Engine = engine;
        this.Weight = weight;
        this.Color = color;
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public int Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    public Engine Engine
    {
        get { return engine; }
        set { this.engine = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }
}

