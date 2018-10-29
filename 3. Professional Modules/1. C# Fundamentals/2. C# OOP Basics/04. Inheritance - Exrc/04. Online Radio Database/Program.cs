using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int songsAmount = int.Parse(Console.ReadLine());

        List<Song> songs = new List<Song>();

        for (int i = 0; i < songsAmount; i++)
        {
            try
            {
                string[] input = Console.ReadLine().Split(';');

                string artistName = input[0];
                string title = input[1];
                string length = input[2];

                TryParseLength(length);

                Tuple<int, int> songDuration = SplitSongLength(length);

                Song song = new Song(artistName, title, songDuration.Item1, songDuration.Item2);
                songs.Add(song);
                Console.WriteLine("Song added.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        Console.WriteLine($"Songs added: {songs.Count}");
        Console.WriteLine($"Playlist length: {CalculatePlaylistLength(songs)}");
    }

    public static Tuple<int, int> SplitSongLength(string length)
    {
        int[] time = length.Split(':').Select(int.Parse).ToArray();

        if (time.Length != 2)
        {
            throw new InvalidSongLengthException();
        }

        int minutes = time[0];
        int seconds = time[1];

        return new Tuple<int, int>(minutes, seconds);
    }

    public static string CalculatePlaylistLength(List<Song> songs)
    {
        string result = string.Empty;
        int minutes = 0;
        int seconds = 0;
        int hours = 0;

        foreach (var song in songs)
        {
            minutes += song.LengthInMinutes;
            seconds += song.LengthInSeconds;
        }

        minutes += seconds / 60;
        seconds = seconds % 60;

        while (minutes >= 60)
        {
            hours++;
            minutes -= 60;
        }

        result = $"{hours}h {minutes}m {seconds}s";

        return result;
    }

    public static void TryParseLength(string length)
    {
        string[] duration = length.Split(':');

        int minutes = 0;
        int seconds = 0;

        bool parseMinutes = int.TryParse(duration[0], out minutes);
        bool parseSeconds = int.TryParse(duration[0], out seconds);

        if (!parseMinutes || !parseSeconds)
        {
            throw new InvalidSongLengthException();
        }

    }
}


