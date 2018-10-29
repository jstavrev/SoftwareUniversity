using System;
using System.Collections.Generic;
using System.Text;


public abstract class Human
{
    private string firstName;
    private string lastName;

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string LastName
    {
        get { return lastName; }
        set
        {
            ValidateName(value, "lastName");
            if (value.Length < 3)
            {
                throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
            }
            lastName = value;
        }
    }

    public string FirstName
    {
        get { return firstName; }
        set
        {
            ValidateName(value, "firstName");
            if (value.Length < 4)
            {
                throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
            }
            firstName = value;
        }
    }

    public void ValidateName(string name, string position)
    {
        bool isUpper = false;
        for (int i = 65; i < 91; i++)
        {
            if (name[0] == (char)i)
            {
                return;
            }
        }
        if (!isUpper)
        {
            throw new ArgumentException($"Expected upper case letter! Argument: {position}");
        }
    }

    public override string ToString()
    {
        return $"First Name: {this.FirstName}\r\nLast Name: {this.LastName}";
    }
}

