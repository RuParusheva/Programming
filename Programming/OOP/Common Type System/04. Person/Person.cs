using System;

public class Person
{
    public string Name { get; set; }
    public int? Age { get; set; }


    public Person(string name) : this(name, null)
    {
    }
    public Person(string name, int? age)
    {
        this.Name = name;
        this.Age = age;
    }

    public override string ToString()
    {
        return String.Format("My name is {0} and my age is {1}.",
            this.Name, (object)this.Age ?? "unknown" );
    }
}
