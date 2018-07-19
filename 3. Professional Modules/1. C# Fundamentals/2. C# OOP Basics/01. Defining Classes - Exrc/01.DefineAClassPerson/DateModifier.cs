using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

public class DateModifier
{
    private int dayDifference;

    public int DayDifference
    {
        get { return dayDifference; }
        set { dayDifference = value; }
    }

    public int DayDifferenceCalculator(string dateOne, string dateTwo)
    {
        DateTime StartDate = DateTime.ParseExact(dateOne, "yyyy MM dd", CultureInfo.InvariantCulture);
        DateTime EndDate = DateTime.ParseExact(dateTwo, "yyyy MM dd", CultureInfo.InvariantCulture);

        int difference = Math.Abs((StartDate - EndDate).Days);

        return difference;
    }

}

