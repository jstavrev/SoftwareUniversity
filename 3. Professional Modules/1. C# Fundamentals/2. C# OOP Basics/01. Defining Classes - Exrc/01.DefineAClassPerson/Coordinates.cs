public class Coordinates
{
    private double x;
    private double y;

    public Coordinates(double x, double y)
    {
        this.X = x;
        this.Y = y;
    }

    public double Y
    {
        get { return y; }
        set { y = value; }
    }

    public double X
    {
        get { return x; }
        set { x = value; }
    }
}