using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string name;
    private decimal money;
    private readonly List<Product> bag;

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        bag = new List<Product>();
    }

    public List<Product> Bag
    {
        get { return new List<Product>(bag); }
    }

    public decimal Money
    {
        get { return money; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            money = value;
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

    public void AddToBag(Product product)
    {
        this.bag.Add(product);
    }

    public string PrintBag()
    {
        string print = string.Empty;

        foreach (var item in bag)
        {
            print += $"{item.Name}, ";
        }
        print = print.TrimEnd(',', ' ');
        return print;
    }
}

