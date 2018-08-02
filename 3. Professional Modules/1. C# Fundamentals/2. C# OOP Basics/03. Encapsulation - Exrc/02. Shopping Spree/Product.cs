using System;
using System.Collections.Generic;
using System.Text;


public class Product
{
    private string name;
    private decimal price;

    public Product(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
    }

    public decimal Price
    {
        get { return price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            price = value;
        }
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (value == null || value.StartsWith(' '))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            name = value;
        }
    }
}

