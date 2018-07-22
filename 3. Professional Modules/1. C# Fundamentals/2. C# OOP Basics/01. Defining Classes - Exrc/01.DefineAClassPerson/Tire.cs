public class Tire
{
    private double tireOnePressure;
    private int tireOneAge;
    private double tireTwoPressure;
    private int tireTwoAge;
    private double tireThreePressure;
    private int tireThreeAge;
    private double tireFourPressure;
    private int tireFourAge;
    private readonly bool lowPressure;

    public Tire(double tireOnePressure, int tireOneAge, double tireTwoPressure, int tireTwoAge, double tireThreePressure, int tireThreeAge, double tireFourPressure, int tireFourAge)
    {
        this.TireOnePressure = tireOnePressure;
        this.TireOneAge = tireOneAge;
        this.TireTwoPressure = tireTwoPressure;
        this.TireTwoAge = tireTwoAge;
        this.TireThreePressure = tireThreePressure;
        this.TireThreeAge = tireThreeAge;
        this.TireFourPressure = tireFourPressure;
        this.TireFourAge = tireFourAge;
        this.lowPressure = tireOnePressure < 1 || tireTwoPressure < 1 || tireThreePressure < 1 || tireFourPressure < 1;
    }

    public bool LowPressure
    {
        get { return this.lowPressure; }
    }

    public int TireFourAge
    {
        get { return tireFourAge; }
        set { tireFourAge = value; }
    }


    public double TireFourPressure
    {
        get { return tireFourPressure; }
        set { tireFourPressure = value; }
    }


    public int TireThreeAge
    {
        get { return tireThreeAge; }
        set { tireThreeAge = value; }
    }


    public double TireThreePressure
    {
        get { return tireThreePressure; }
        set { tireThreePressure = value; }
    }



    public int TireTwoAge
    {
        get { return tireTwoAge; }
        set { tireTwoAge = value; }
    }


    public double TireTwoPressure
    {
        get { return tireTwoPressure; }
        set { tireTwoPressure = value; }
    }


    public int TireOneAge
    {
        get { return tireOneAge; }
        set { tireOneAge = value; }
    }


    public double TireOnePressure
    {
        get { return tireOnePressure; }
        set { tireOnePressure = value; }
    }
}