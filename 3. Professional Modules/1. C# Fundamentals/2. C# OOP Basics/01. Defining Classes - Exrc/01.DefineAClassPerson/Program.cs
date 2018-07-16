using System;
using System.Linq;
using System.Reflection;

public class Program
{
    static void Main(string[] args)
    {
        Family familyMembers = new Family();

        int n = int.Parse(Console.ReadLine());       

        for (int i = 0; i < n; i++)
        {
            string[] people = Console.ReadLine().Split().ToArray();
            Person addToList = new Person(people[0], int.Parse(people[1]));
            familyMembers.AddMember(addToList);
        }
        Person oldestMember = familyMembers.GetOldestMember();
        Console.WriteLine(oldestMember.ToString());        
    }
}

