using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        this.Age = age;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Salary = salary;
    }

    public decimal Salary
    {
        get { return salary; }
        set
        {
            if (value < 460)
            {
                throw new ArgumentException("Salary cannot be less than 460 leva!");
            }
            salary = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 1)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }
            age = value;
        }
    }

    public string LastName
    {
        get { return lastName; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
            }
            lastName = value;
        }
    }

    public string FirstName
    {
        get { return firstName; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            }
            firstName = value;
        }
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} receives {this.Salary:F2} leva.";
    }

    public void IncreaseSalary(decimal bonus)
    {
        if (this.Age < 30)
        {
            this.Salary += (this.Salary * (bonus / 100)) / 2;
        }
        else
        {
            this.Salary += (this.Salary * (bonus / 100));
        }
    }
}

