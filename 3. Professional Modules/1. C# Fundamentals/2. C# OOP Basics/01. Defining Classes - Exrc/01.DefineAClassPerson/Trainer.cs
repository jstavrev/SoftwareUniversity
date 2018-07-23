using System;
using System.Collections.Generic;
using System.Text;


class Trainer
{
    private string name;
    private int badges = 0;
    private List<Pokemon> pokemons;

    public Trainer(string name)
    {
        this.Name = name;
        this.pokemons = new List<Pokemon>();
    }

    public void AddPokemon(Pokemon pokemon)
    {
        this.pokemons.Add(pokemon);
    }

    public void IncreaseBadges()
    {
        this.badges++;
    }

    public List<Pokemon> Pokemons
    {
        get { return new List<Pokemon>(this.pokemons); }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Badges
    {
        get { return this.badges; }
    }
}

