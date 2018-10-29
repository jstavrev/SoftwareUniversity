using System;
using System.Collections.Generic;
using System.Text;


public class Tomcat : Cat
{
    public Tomcat(string name, string gender, int age) : base(name, gender, age)
    {
        base.Gender = "Male";
    }

    public override void ProduceSound()
    {
        Console.WriteLine("MEOW");
    }
}

