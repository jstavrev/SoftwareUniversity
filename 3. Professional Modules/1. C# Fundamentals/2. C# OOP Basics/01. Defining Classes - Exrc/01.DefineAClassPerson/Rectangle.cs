using System;
using System.Collections.Generic;
using System.Text;


class Rectangle
{
    private string id;
    private double width;
    private double height;
    private Coordinates topLeft;

    public Rectangle(string id, double width, double height, Coordinates topLeft)
    {
        this.Id = id;
        this.Width = width;
        this.Height = height;
        this.TopLeft = topLeft;
    }
    public Coordinates TopLeft
    {
        get { return this.topLeft; }
        set { this.topLeft = value; }
    }

    public double Height
    {
        get { return height; }
        set { height = value; }
    }

    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    public string Id
    {
        get { return id; }
        set { id = value; }
    }
}

