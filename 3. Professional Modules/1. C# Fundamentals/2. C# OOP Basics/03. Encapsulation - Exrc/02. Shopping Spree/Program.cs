using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        List<string> inputOfPeople = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        List<string> inputOfProducts = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        List<Person> people = new List<Person>();
        List<Product> products = new List<Product>();

        foreach (var person in inputOfPeople)
        {
            try
            {
                string[] splitInput = person.Split(new char[] { '=' }).ToArray();
                string name = splitInput[0];
                decimal money = decimal.Parse(splitInput[1]);

                Person newPerson = new Person(name, money);
                people.Add(newPerson);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
        }

        foreach (var product in inputOfProducts)
        {
            try
            {
                string[] splitInput = product.Split(new char[] { '=' }).ToArray();
                string name = splitInput[0];
                decimal price = decimal.Parse(splitInput[1]);

                Product newProduct = new Product(name, price);
                products.Add(newProduct);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
        }

        while (true)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            if (input[0] == "END")
            {
                break;
            }

            foreach (var person in people)
            {
                if (person.Name == input[0])
                {
                    foreach (var product in products)
                    {
                        if (product.Name == input[1])
                        {
                            if (person.Money - product.Price >= 0)
                            {
                                person.AddToBag(product);
                                person.Money -= product.Price;
                                Console.WriteLine($"{person.Name} bought {product.Name}");
                            }
                            else
                            {
                                Console.WriteLine($"{person.Name} can't afford {product.Name}");
                            }
                            break;
                        }
                    }
                    break;
                }
            }
        }
        foreach (var person in people)
        {
            Console.Write($"{person.Name} - ");
            if (person.Bag.Count > 0)
            {
                Console.Write(person.PrintBag());
            }
            else
            {
                Console.Write("Nothing bought");
            }
            Console.WriteLine();
        }
    }
}

