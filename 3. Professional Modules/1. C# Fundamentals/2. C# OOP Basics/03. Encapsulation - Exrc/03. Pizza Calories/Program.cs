using System;
using System.Linq;

namespace _03._Pizza_Calories
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new Pizza();

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                try
                {
                    if (input[0] == "END")
                    {
                        break;
                    }

                    if (input[0] == "Pizza")
                    {
                        string pizzaName = input[1];
                        pizza.SetName(pizzaName);
                    }
                    else if (input[0] == "Dough")
                    {
                        string flourType = input[1];
                        string bakingTechnique = input[2];
                        int weight = int.Parse(input[3]);

                        Dough dough = new Dough(flourType, bakingTechnique, weight);
                        pizza.SetDough(dough);
                    }
                    else if (input[0] == "Topping")
                    {
                        string type = input[1];
                        int weight = int.Parse(input[2]);

                        Toppings topping = new Toppings(type, weight);
                        pizza.AddNewTopping(topping);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }
            Console.WriteLine($"{pizza.Name} - {pizza.CalculatePizzaCalories():F2} Calories.");
        }
    }
}
