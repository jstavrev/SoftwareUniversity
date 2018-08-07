using System;
using System.Collections.Generic;
using System.Text;


public abstract class Animals
{
    private string name;
    private int age;
    private string gender;

    public Animals(string name, string gender, int age)
    {
        this.Name = name;
        this.Gender = gender;
        this.Age = age;
    }

    public string Gender
    {
        get { return gender; }
        set { gender = value; }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid input!");
            }
            age = value;
        }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public abstract void ProduceSound();
}

