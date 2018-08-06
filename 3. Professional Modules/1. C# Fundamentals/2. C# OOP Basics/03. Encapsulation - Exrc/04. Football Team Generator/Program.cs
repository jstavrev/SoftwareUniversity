using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, FootballTeam> teams = new Dictionary<string, FootballTeam>();

        while (true)
        {
            string[] input = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (input[0] == "END")
            {
                break;
            }

           try
            {
                if (input[0] == "Team")
                {
                    FootballTeam newTeam = new FootballTeam(input[1]);
                    teams[input[1]] = newTeam;
                }
                else if (input[0] == "Add")
                {
                    if (teams.ContainsKey(input[1]))
                    {
                        string playerName = input[2];
                        int endurance = int.Parse(input[3]);
                        int sprint = int.Parse(input[4]);
                        int dribble = int.Parse(input[5]);
                        int passing = int.Parse(input[6]);
                        int shooting = int.Parse(input[7]);

                        FootballPlayer player = new FootballPlayer(playerName, endurance, sprint, dribble, passing, shooting);

                        teams[input[1]].Players[input[2]] = player;
                    }
                    else
                    {
                        Console.WriteLine($"Team {input[1]} does not exist.");
                    }
                }
                else if (input[0] == "Remove")
                {
                    if (teams.ContainsKey(input[1]))
                    {
                        if (teams[input[1]].Players.ContainsKey(input[2]))
                        {
                            teams[input[1]].Players[input[2]] = null;
                        }
                        else
                        {
                            Console.WriteLine($"Player {input[2]} is not in {input[1]} team.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Team {input[1]} does not exist.");
                    }
                }
                else if (input[0] == "Rating")
                {
                    if (teams.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{input[1]} - {teams[input[1]].CalculateTeamRating()}");
                    }
                    else
                    {
                        Console.WriteLine($"Team {input[1]} does not exist.");
                    }
                }           
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

