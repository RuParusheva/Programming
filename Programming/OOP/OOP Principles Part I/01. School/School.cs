using System;
using System.Collections.Generic;

public class School
{
    private string name;
    private List<SchoolClass> classes = new List<SchoolClass>();

    public School(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get { return this.name; }
    }

    public void AddClass(SchoolClass oneSchoolClass)
    {
        this.classes.Add(oneSchoolClass);
    }

    public void RemoveClass(SchoolClass oneSchoolClass)
    {
        this.classes.Remove(oneSchoolClass);
    }
}
