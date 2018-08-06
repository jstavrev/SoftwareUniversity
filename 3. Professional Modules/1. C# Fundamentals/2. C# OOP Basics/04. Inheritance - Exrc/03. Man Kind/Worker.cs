using System;
using System.Collections.Generic;
using System.Text;


public class Worker : Human
{
    private decimal weekSalary;
    private decimal workHoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, decimal payPerHour) : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = payPerHour;
    }

    public decimal WorkHoursPerDay
    {
        get { return workHoursPerDay; }
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            workHoursPerDay = value;
        }
    }

    public decimal WeekSalary
    {
        get { return weekSalary; }
        set
        {
            if (value < 11)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            weekSalary = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine(base.ToString());
        sb.AppendLine($"Week Salary: {this.WeekSalary:F2}");
        sb.AppendLine($"Hours per day: {this.WorkHoursPerDay:F2}");
        sb.Append($"Salary per hour: {this.CalcMoneyPerHour():F2}");

        return sb.ToString();
    }

    public decimal CalcMoneyPerHour()
    {
        return this.WeekSalary / (this.WorkHoursPerDay * 5);
    }
}

