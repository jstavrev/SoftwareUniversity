using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Book
{
    private string title;
    private string author;
    protected decimal price;

    public Book(string title, string author, decimal price)
    {
        this.Title = title;
        this.Author = author;
        this.Price = price;
    }

    public virtual decimal Price
    {
        get { return price; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }
            price = value;
        }
    }

    public string Author
    {
        get { return author; }
        set
        {
            ValidateAuthorName(value);
            author = value;
        }
    }

    public string Title
    {
        get { return title; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }
            title = value;
        }
    }

    public void ValidateAuthorName(string name)
    {
        string[] fullName = name.Split().ToArray();

        if (fullName.Length > 1)
        {
            for (int i = 49; i < 58; i++)
            {
                if (fullName[0].StartsWith((char)i) || fullName[1].StartsWith((char)i))
                {
                    throw new ArgumentException("Author not valid!");
                }
            }
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Type: Book");
        sb.AppendLine($"Title: {this.Title}");
        sb.AppendLine($"Author: {this.Author}");
        sb.Append($"Price: {this.Price:F2}");

        return sb.ToString();
    }
}

