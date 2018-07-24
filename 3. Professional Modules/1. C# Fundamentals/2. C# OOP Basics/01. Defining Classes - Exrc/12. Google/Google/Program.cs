using System;
using System.Collections.Generic;
using System.Linq;

namespace Google
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> peopleList = new Dictionary<string, Person>();

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                if (input[0] == "End")
                {
                    break;
                }

                string personName = input[0];
                string command = input[1];

                if (!peopleList.ContainsKey(personName))
                {
                    peopleList[personName] = new Person(personName);
                }

                switch (command)
                {
                    case "company":
                        string companyName = input[2];
                        string department = input[3];
                        decimal salary = decimal.Parse(input[4]);
                        Company workPlace = new Company(companyName, department, salary);
                        peopleList[personName].WorkPlace = workPlace;
                        break;
                    case "pokemon":
                        string pokemonName = input[2];
                        string pokemonType = input[3];
                        Pokemon pokemon = new Pokemon(pokemonName, pokemonType);
                        peopleList[personName].Pokemons.Add(pokemon);
                        break;
                    case "parents":
                        string parentName = input[2];
                        string parentBirthday = input[3];
                        Parent parent = new Parent(parentName, parentBirthday);
                        peopleList[personName].Parents.Add(parent);
                        break;
                    case "children":
                        string childName = input[2];
                        string childBirthday = input[3];
                        Children child = new Children(childName, childBirthday);
                        peopleList[personName].Children.Add(child);
                        break;
                    case "car":
                        string carModel = input[2];
                        int carSpeed = int.Parse(input[3]);
                        Car car = new Car(carModel, carSpeed);
                        peopleList[personName].Car = car;
                        break;
                }
            }
            string name = Console.ReadLine();
            PrintPersonInformation(name, peopleList);
        }

        private static void PrintPersonInformation(string name, Dictionary<string, Person> peopleList)
        {
            Console.WriteLine(name);
            Console.WriteLine("Company:");
            if (!(peopleList[name].WorkPlace == null))
            {
                Console.WriteLine($"{peopleList[name].WorkPlace.CompanyName} {peopleList[name].WorkPlace.Department} {peopleList[name].WorkPlace.Salary:F2}");
            }
            Console.WriteLine("Car:");
            if (!(peopleList[name].Car == null))
            {
                Console.WriteLine($"{peopleList[name].Car.CarModel} {peopleList[name].Car.CarSpeed}");
            }
            Console.WriteLine("Pokemon:");
            if (!(peopleList[name].Pokemons == null))
            {
                foreach (var pokemon in peopleList[name].Pokemons)
                {
                    Console.WriteLine($"{pokemon.PokemonName} {pokemon.PokemonType}");
                }
            }
            Console.WriteLine("Parents:");
            if (!(peopleList[name].Parents == null))
            {
                foreach (var parent in peopleList[name].Parents)
                {
                    Console.WriteLine($"{parent.ParentName} {parent.ParentBirthday}");
                }
            }
            Console.WriteLine("Children:");
            if (!(peopleList[name].Children == null))
            {
                foreach (var child in peopleList[name].Children)
                {
                    Console.WriteLine($"{child.ChildName} {child.ChildBirthday}");
                }
            }
        }
    }
}
