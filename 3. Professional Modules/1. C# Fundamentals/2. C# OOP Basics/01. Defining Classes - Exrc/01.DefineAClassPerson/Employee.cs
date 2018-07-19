using System;
using System.Collections.Generic;
using System.Text;


public class Employee
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private double salary;

    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    private string position;

    public string Position
    {
        get { return position; }
        set { position = value; }
    }

    private string department;

    public string Department
    {
        get { return department; }
        set { department = value; }
    }

    private string email;

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    private int age;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Employee(string name, double salary, string position, string department, string email = "n/a", int age = -1)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.email = email;
        this.age = age;
    }
}

