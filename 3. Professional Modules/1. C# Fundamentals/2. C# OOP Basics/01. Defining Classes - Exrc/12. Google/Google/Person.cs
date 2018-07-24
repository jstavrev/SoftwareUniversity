using System;
using System.Collections.Generic;
using System.Text;


class Person
{
    private Company workPlace;
    private Car car;
    private List<Pokemon> pokemons;
    private List<Parent> parents;
    private List<Children> children;
    private string personName;

    public Person(string personName)
    {
        this.PersonName = personName;
        this.Pokemons = new List<Pokemon>();
        this.Parents = new List<Parent>();
        this.Children = new List<Children>();
    }

    public string PersonName
    {
        get { return personName; }
        set { personName = value; }
    }

    public List<Children> Children
    {
        get { return children; }
        private set { children = value; }
    }

    public List<Parent> Parents
    {
        get { return parents; }
        private set { parents = value; }
    }

    public List<Pokemon> Pokemons
    {
        get { return pokemons; }
        private set { pokemons = value; }
    }

    public Car Car
    {
        get { return car; }
        set { car = value; }
    }

    public Company WorkPlace
    {
        get { return workPlace; }
        set { workPlace = value; }
    }
}

