using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Animals> animals = new List<Animals>();

        string name;
        int age;
        string gender = string.Empty;

        while (true)
        {
            try
            {
                string animalType = Console.ReadLine();

                if (animalType == "Beast!")
                {
                    break;
                }

                string[] animalStats = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (animalType == "Kitten" || animalType == "Tomcat")
                {
                    if (animalStats.Length != 2 && animalStats.Length != 3)
                    {
                        throw new Exception("Invalid input!");
                    }

                    name = animalStats[0];
                    age = int.Parse(animalStats[1]);
                }
                else
                {
                    if (animalStats.Length != 3)
                    {
                        throw new Exception("Invalid input!");
                    }
                    name = animalStats[0];
                    age = int.Parse(animalStats[1]);
                    gender = animalStats[2];
                }

                Animals animal = (Animals)Activator.CreateInstance(Type.GetType(animalType), name, gender, age);
                animals.Add(animal);
            }
            catch 
            {
                Console.WriteLine("Invalid input!");
            }
        }

        foreach (var animal in animals)
        {
            Console.WriteLine($"{animal.GetType()}");
            Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
            animal.ProduceSound();
        }
    }
}

