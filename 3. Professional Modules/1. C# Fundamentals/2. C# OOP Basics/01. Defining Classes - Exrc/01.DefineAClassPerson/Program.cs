using System;
using System.Linq;
using System.Reflection;

public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] inputEmployee = new string[6];
        for (int i = 0; i < n; i++)
        {
            inputEmployee = Console.ReadLine().Split().ToArray();

        }
    }
}

