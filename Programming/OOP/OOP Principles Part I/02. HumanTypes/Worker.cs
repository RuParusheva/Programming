using System;
using System.Text;

public class Worker: Human
{
    private decimal weekSalary;
    private decimal workHoursPerDay;
    private const decimal WorkDays = 5;

    public decimal WeekSalary
    {
        get { return this.weekSalary; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Invalid salary");
            }
            this.weekSalary = value;
        }
    }

    public decimal WorkHoursPerDay
    {
        get { return this.workHoursPerDay; }
        set
        {
            if (value <= 0 || value > 24)
            {
                throw new ArgumentException("Workhours per day cannot exceed 24 or be less or equal to 0");
            }
            this.workHoursPerDay = value;
        }
    }

    public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public decimal MoneyPerHour()
    {
        decimal result = this.weekSalary/this.workHoursPerDay/WorkDays;
        return result;
    }

    public override string ToString()
    {
        StringBuilder info = new StringBuilder();
        info.Append(base.ToString());
        info.AppendFormat("; Week salary: {0}; Work hours by day: {1}; Money per hour: {2:0.00}", this.WeekSalary, this.WorkHoursPerDay, this.MoneyPerHour());
        return info.ToString();
    }
}
