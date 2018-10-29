using System;
using System.Collections.Generic;
using System.Text;


public class Pizza
{
    private string name;
    private Dough dough;
    private List<Toppings> toppings;

    public Pizza()
    {
        this.Toppings = new List<Toppings>();
    }

    public Pizza(string name)
    {
        this.Name = name;
        this.Toppings = new List<Toppings>();
    }

    public List<Toppings> Toppings
    {
        get { return toppings; }
        set
        {
            toppings = value;
        }
    }

    public Dough Dough
    {
        get { return dough; }
        private set { dough = value; }
    }

    public string Name
    {
        get { return name; }
        private set
        {
            if (value.Length < 1 || value.Length > 15)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
            name = value;
        }
    }

    public double CalculatePizzaCalories()
    {
        double doughCals = this.Dough.CalcCalories();
        double toppingCals = 0;

        foreach (var topping in this.Toppings)
        {
            double modifier = topping.ToppingModifier(topping.Name.ToLower());

            toppingCals += modifier * topping.Weight * 2;
        }

        return doughCals + toppingCals;
    }

    public void SetDough(Dough dough)
    {
        this.Dough = dough;
    }

    public void SetName(string name)
    {
        this.Name = name;
    }

    public void AddNewTopping(Toppings topping)
    {
        if (this.Toppings.Count > 10)
        {
            throw new ArgumentException("Number of toppings should be in range [0..10].");
        }
        this.Toppings.Add(topping);
    }
}

