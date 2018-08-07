using System;
using System.Collections.Generic;
using System.Text;


public class Dog : Animals
{
    public Dog(string name, string gender, int age) : base(name, gender, age)
    {
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Woof!");
    }
}

