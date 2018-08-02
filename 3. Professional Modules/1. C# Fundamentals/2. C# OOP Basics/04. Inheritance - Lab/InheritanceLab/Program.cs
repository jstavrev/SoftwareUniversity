using System;


public class Program
{
    static void Main(string[] args)
    {
        RandomList list = new RandomList();

        list.Add("dasbas");
        list.Add("gazvaz");
        list.Add("gezbez");

        string random = list.RandomString(list);
        Console.WriteLine(random);
    }
}

