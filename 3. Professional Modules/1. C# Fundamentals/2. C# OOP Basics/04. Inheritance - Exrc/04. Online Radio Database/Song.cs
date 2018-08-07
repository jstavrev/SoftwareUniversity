using System;
using System.Collections.Generic;
using System.Text;


public class Song
{
    private string artistName;
    private string title;
    private int lengthInSeconds;
    private int lengthInMinutes;

    public Song(string artistName, string title, int lengthInMinutes, int lengthInSeconds)
    {
        this.ArtistName = artistName;
        this.Title = title;
        this.LengthInMinutes = lengthInMinutes;
        this.LengthInSeconds = lengthInSeconds;
    }

    public int LengthInMinutes
    {
        get { return lengthInMinutes; }
        set
        {
            if (value < 0 || value > 14)
            {
                throw new InvalidSongMinutesException();
            }
            lengthInMinutes = value;
        }
    }

    public int LengthInSeconds
    {
        get { return lengthInSeconds; }
        set
        {
            if (value < 0 || value > 59)
            {
                throw new InvalidSongSecondsException();
            }
            lengthInSeconds = value;
        }
    }

    public string Title
    {
        get { return title; }
        set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new InvalidSongNameException();
            }
            title = value;
        }
    }

    public string ArtistName
    {
        get { return artistName; }
        set
        {
            if (value.Length < 3 || value.Length > 20)
            {
                throw new InvalidArtistNameException();
            }
            artistName = value;
        }
    }
}

