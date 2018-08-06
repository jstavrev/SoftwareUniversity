using System;
using System.Collections.Generic;
using System.Text;


public class Dough
{
    private string flourType;
    private string bakingTechnique;
    private int weight;

    public Dough()
    {

    }

    public Dough(string flourType, string bakingTechnique, int weight)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Weight = weight;
    }

    public int Weight
    {
        get { return weight; }
        set
        {
            if (value < 1 || value > 200)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }
            weight = value;
        }
    }

    public string BakingTechnique
    {
        get { return bakingTechnique; }
        private set
        {
            if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            bakingTechnique = value;
        }
    }

    public string FlourType
    {
        get { return flourType; }
        private set
        {
            if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            flourType = value;
        }
    }

    private double FlourModifier(string flourType)
    {
        switch (flourType.ToLower())
        {
            case "white":
                return 1.5;
            case "wholegrain":
                return 1.0;
            default:
                throw new ArgumentException("Invalid flour type.");
        }
    }

    private double BakingModifier(string bakingTechnique)
    {
        switch (bakingTechnique.ToLower())
        {
            case "crispy":
                return 0.9;
            case "chewy":
                return 1.1;
            case "homemade":
                return 1.0;
            default:
                throw new ArgumentException("Invalid baking technique.");
        }
    }

    public double CalcCalories()
    {
        double flourModifier = FlourModifier(this.FlourType);
        double bakingModifier = BakingModifier(this.BakingTechnique);

        return 2 * this.Weight * flourModifier * bakingModifier;
    }
}

