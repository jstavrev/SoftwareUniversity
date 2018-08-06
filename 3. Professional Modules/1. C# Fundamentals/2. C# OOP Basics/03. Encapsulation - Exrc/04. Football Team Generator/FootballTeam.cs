using System;
using System.Collections.Generic;
using System.Text;


public class FootballTeam
{
    private string name;
    private int teamRating;
    private Dictionary<string, FootballPlayer> players;

    public FootballTeam(string name)
    {
        this.Name = name;
        this.Players = new Dictionary<string, FootballPlayer>();
    }

    public Dictionary<string, FootballPlayer> Players
    {
        get { return players; }
        set { players = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    } 
    
    public double CalculateTeamRating()
    {
        Dictionary<string, FootballPlayer> team = this.Players;
        double teamRating = 0;
        foreach (var player in team)
        {
            if (player.Value != null)
            {
                teamRating += player.Value.Stats;
            }
        }
        int count = 0;
        if (count != 0)
        {
            foreach (var item in team)
            {
                if (item.Value != null)
                {
                    count++;
                }
            }
            teamRating = Math.Round(teamRating / count);
        }

        return teamRating;
    }
}

