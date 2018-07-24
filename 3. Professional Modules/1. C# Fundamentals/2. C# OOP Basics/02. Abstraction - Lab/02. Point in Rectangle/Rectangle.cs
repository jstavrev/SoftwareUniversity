using System;
using System.Collections.Generic;
using System.Text;


public class Rectangle
{
    private int topLeftX;
    private int topLeftY;
    private int bottomRightX;
    private int bottomRightY;

    public Rectangle(int topLeftX, int topLeftY, int bottomRightX, int bottomRightY)
    {
        this.TopLeftX = topLeftX;
        this.TopLeftY = topLeftY;
        this.BottomRightX = bottomRightX;
        this.BottomRightY = bottomRightY;
    }

    public bool Contains(Point point)
    {
        bool doesContain = false;

        doesContain = point.X >= TopLeftX && point.X <= BottomRightX && point.Y >= TopLeftY && point.Y <= BottomRightY;

        return doesContain;
    }

    public int BottomRightY
    {
        get { return bottomRightY; }
        set { bottomRightY = value; }
    }

    public int BottomRightX
    {
        get { return bottomRightX; }
        set { bottomRightX = value; }
    }

    public int TopLeftY
    {
        get { return topLeftY; }
        set { topLeftY = value; }
    }

    public int TopLeftX
    {
        get { return topLeftX; }
        set { topLeftX = value; }
    }
}

