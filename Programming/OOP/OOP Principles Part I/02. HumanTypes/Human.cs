using System;
using System.Text;

public abstract class Human
{

    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public override string ToString()
    {
        StringBuilder fullName = new StringBuilder();
        fullName.AppendFormat("Name: {0} {1}", this.FirstName, this.LastName);
        return fullName.ToString();
    }
}
