using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class Program
{
    static void Main(string[] args)
    {
        Dictionary<Trainer, List<Pokemon>> trainersCollection = new Dictionary<Trainer, List<Pokemon>>();
        List<string> trainersName = new List<string>();

        while (true)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            if (input[0] == "Tournament")
            {
                break;
            }

            string trainerName = input[0];
            string pokemonName = input[1];
            string element = input[2];
            int health = int.Parse(input[3]);

            Pokemon pokemon = new Pokemon(pokemonName, element, health);
            Trainer trainer = new Trainer(trainerName);
            trainer.Pokemons.Add(pokemon);
            if (trainersName.Contains(trainerName))
            {
                foreach (var train in trainersCollection)
                {
                    if (train.Key.Name == trainerName)
                    {
                        train.Value.Add(pokemon);
                    }
                }
            }
            else
            {
                trainersName.Add(trainerName);
                trainersCollection[trainer] = new List<Pokemon>();
                trainersCollection[trainer].Add(pokemon);
            }
        }
        bool containsElement = false;
        while (true)
        {
            string input = Console.ReadLine();

            if (input == "End")
            {
                break;
            }

            if (input == "Fire")
            {
                foreach (var trainer in trainersCollection)
                {
                    containsElement = false;
                    foreach (var pokemon in trainer.Value)
                    {
                        if (pokemon.Element == "Fire")
                        {
                            trainer.Key.IncreaseBadges();
                            containsElement = true;
                            break;
                        }
                    }
                    if (!containsElement)
                    {
                        foreach (var pokemon in trainer.Value)
                        {
                            pokemon.RemoveHealth();
                        }
                        trainer.Value.RemoveAll(x => x.Health <= 0);
                    }
                }
            }
            else if (input == "Water")
            {
                foreach (var trainer in trainersCollection)
                {
                    containsElement = false;
                    foreach (var pokemon in trainer.Value)
                    {
                        if (pokemon.Element == "Water")
                        {
                            trainer.Key.IncreaseBadges();
                            containsElement = true;
                            break;
                        }
                    }
                    if (!containsElement)
                    {
                        foreach (var pokemon in trainer.Value)
                        {
                            pokemon.RemoveHealth();
                        }
                        trainer.Value.RemoveAll(x => x.Health <= 0);
                    }
                }
            }
            else if (input == "Electricity")
            {
                foreach (var trainer in trainersCollection)
                {
                    containsElement = false;
                    foreach (var pokemon in trainer.Value)
                    {
                        if (pokemon.Element == "Electricity")
                        {
                            trainer.Key.IncreaseBadges();
                            containsElement = true;
                            break;
                        }
                    }
                    if (!containsElement)
                    {
                        foreach (var pokemon in trainer.Value)
                        {
                            pokemon.RemoveHealth();
                        }
                        trainer.Value.RemoveAll(x => x.Health <= 0);
                    }
                }
            }          
        }

        foreach (var trainer in trainersCollection.OrderByDescending(x => x.Key.Badges))
        {
            Console.WriteLine($"{trainer.Key.Name} {trainer.Key.Badges} {trainer.Value.Count}");
        }
    }
}

