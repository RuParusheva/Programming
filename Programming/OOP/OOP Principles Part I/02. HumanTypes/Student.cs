using System;
using System.Text;

public class Student: Human
{
    private decimal grade;

    public decimal Grade
    {
        get { return this.grade; }
        private set
        {
            if (value < 2 || value > 6)
            {
                throw new ArgumentException("Invalid grade!");
            }
            this.grade = value;
        }
    }

    public Student(string firstName, string lastName, decimal grade)
        : base(firstName, lastName)
    {
        this.Grade = grade;
    }

    public override string ToString()
    {
        StringBuilder info = new StringBuilder();
        info.Append(base.ToString());
        info.AppendFormat("; Grade: {0}", this.Grade);
        return info.ToString();
    }
}
