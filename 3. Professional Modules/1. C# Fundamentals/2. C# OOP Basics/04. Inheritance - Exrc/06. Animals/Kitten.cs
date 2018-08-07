using System;
using System.Collections.Generic;
using System.Text;


public class Kitten : Cat
{
    public Kitten(string name, string gender, int age) : base(name, gender, age)
    {
        base.Gender = "Female";
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Meow");
    }
}

