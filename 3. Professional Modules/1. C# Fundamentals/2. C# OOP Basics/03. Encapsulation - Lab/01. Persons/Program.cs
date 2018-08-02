using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var lines = int.Parse(Console.ReadLine());
        var team = new Team("arsenal");
        for (int i = 0; i < lines; i++)
        {
            var cmdArgs = Console.ReadLine().Split();
            try
            {
                var person = new Person(cmdArgs[0],
                                    cmdArgs[1],
                                    int.Parse(cmdArgs[2]),
                                    decimal.Parse(cmdArgs[3]));
                team.AddPlayer(person);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
        Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");

    }
}

