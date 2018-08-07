﻿using System;
using System.Collections.Generic;
using System.Text;


public class Frog : Animals
{
    public Frog(string name, string gender, int age) : base(name, gender, age)
    {
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Ribbit");
    }
}

