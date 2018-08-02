using System;
using System.Collections.Generic;
using System.Text;


public class Team
{
    private string name;
    private readonly List<Person> firstTeam;
    private readonly List<Person> reserveTeam;

    public Team(string name)
    {
        this.Name = name;
        this.firstTeam = new List<Person>();
        this.reserveTeam = new List<Person>();
    }

    public List<Person> ReserveTeam
    {
        get { return new List<Person>(reserveTeam); }
    }


    public List<Person> FirstTeam
    {
        get { return new List<Person>(firstTeam); }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public void AddPlayer(Person person)
    {
        if (person.Age < 40)
        {
            firstTeam.Add(person);
        }
        else
        {
            reserveTeam.Add(person);
        }
    }
}

