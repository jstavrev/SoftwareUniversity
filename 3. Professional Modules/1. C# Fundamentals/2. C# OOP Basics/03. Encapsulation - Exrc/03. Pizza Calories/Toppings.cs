using System;
using System.Collections.Generic;
using System.Text;


public class Toppings
{
    private string name;
    private int weight;

    public Toppings(string name, int weight)
    {
        this.Name = name;
        this.Weight = weight;
    }

    public int Weight
    {
        get { return weight; }
        set
        {
            if (value < 1 || value > 50)
            {
                throw new ArgumentException($"{this.Name} weight should be in the range [1..50].");
            }
            weight = value;
        }
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (!ValidateToppingName(value.ToLower()))
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            name = value;
        }
    }

    public bool ValidateToppingName(string name)
    {
        if (name == "meat" || name == "veggies" || name == "cheese" || name == "sauce")
        {
            return true;
        }
        return false;
    }

    public double ToppingModifier(string name)
    {
        switch (name.ToLower())
        {
            case "meat":
                return 1.2;
            case "veggies":
                return 0.8;
            case "cheese":
                return 1.1;
            case "sauce":
                return 0.9;
            default:
                throw new ArgumentException("Invalid topping type.");
        }
    }
}
