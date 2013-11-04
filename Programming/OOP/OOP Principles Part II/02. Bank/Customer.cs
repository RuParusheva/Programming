using System;

public abstract class Customer
{
    private string name;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    protected Customer(string name)
    {
        this.Name = name;
    }

    public override string ToString()
    {
        return string.Format("My name is {0} and I am a/an {1}.", this.Name, this.GetType());
    }
}
