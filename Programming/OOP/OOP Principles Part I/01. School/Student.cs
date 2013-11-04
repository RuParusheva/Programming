using System;
using System.Text;

public class Student : Person
{
    private string classNumber;

    public Student(string firstName, string lastName, string classNumber)
        : base(firstName, lastName)
    {
        this.ClassNumber = classNumber;
    }

    public Student(string firstName, string lastName, string comment, string classNumber)
        : base(firstName, lastName, comment)
    {
        this.ClassNumber = classNumber;
        Comment = comment;
    }


    public string ClassNumber
    {
        get { return this.classNumber; }
        set { this.classNumber = value; }
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.AppendFormat("{0} \nClassnumber: {1} ", base.ToString(), classNumber);
        return result.ToString();
    }
}
