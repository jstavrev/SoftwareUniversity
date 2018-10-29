using System;
using System.Collections.Generic;
using System.Text;


public class FootballPlayer
{
    private string name;
    private double stats;
    private int endurance;
    private int sprint;
    private int dribble;
    private int passing;
    private int shooting;

    public FootballPlayer(string name, int endurance, int sprint, int dribble, int passing, int shooting)
    {
        this.Name = name;
        this.Endurance = endurance;
        this.Sprint = sprint;
        this.Dribble = dribble;
        this.Passing = passing;
        this.Shooting = shooting;
        this.Stats = CalculateStats();
    }

    public int Shooting
    {
        get { return shooting; }
        private set
        {
            ValidateSkills(value, "Shooting");
            shooting = value;
        }
    }

    public int Passing
    {
        get { return passing; }
        private set
        {
            ValidateSkills(value, "Passing");
            passing = value;
        }
    }

    public int Dribble
    {
        get { return dribble; }
        private set
        {
            ValidateSkills(value, "Dribble");
            dribble = value;
        }
    }

    public int Sprint
    {
        get { return sprint; }
        private set
        {
            ValidateSkills(value, "Sprint");
            sprint = value;
        }
    }

    public int Endurance
    {
        get { return endurance; }
        private set
        {
            ValidateSkills(value, "Endurance");
            endurance = value;
        }
    }

    public double Stats
    {
        get { return stats; }
        private set { stats = value; }
    }

    public string Name
    {
        get { return name; }
        private set
        {
            if (value == null || value.StartsWith(' '))
            {
                throw new ArgumentException("A name should not be empty.");
            }
            name = value;
        }
    }

    private double CalculateStats()
    {
        return Math.Round((this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5d);
    }

    private void ValidateSkills(int skill, string skillType)
    {
        if (skill < 0 || skill > 100)
        {
            throw new ArgumentException($"{skillType} should be between 0 and 100.");
        }
    }
}

