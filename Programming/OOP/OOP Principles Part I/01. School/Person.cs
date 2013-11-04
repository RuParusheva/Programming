using System;
using System.Text;

public class Person
{
    private string firstName;
    private string lastName;
    private string comment;

    public string Comment
    {
        get { return this.comment; }
        set { this.comment = value; }
    }

    public string FirstName
    {
        get { return this.firstName; }
        set { this.firstName = value; }
    }

    public string LastName
    {
        get { return this.lastName; }
        set { this.lastName = value; }
    }

    public Person(string firstName, string lastName) : this(firstName, lastName, null)
    {
    }

    public Person(string firstName, string lastName,string comment)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Comment = comment;
    }

    public override string ToString()
    {
        StringBuilder fullName = new StringBuilder();
        fullName.AppendFormat("Name: {0} {1}", firstName, lastName);

        if (Comment != null)
        {
            fullName.Append(Environment.NewLine);
            fullName.Append("Comments:");
            fullName.Append("\"");
            fullName.Append(Comment);
            fullName.Append("\"");
        }
        return fullName.ToString();
    }
}
