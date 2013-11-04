using System;
using System.Collections;
using System.Collections.Generic;

public class SchoolClass
{
    private List<Teacher> teachers;
    private string textIdentifier;
    private string comment;

    public List<Teacher> Teachers
    {
        get { return this.teachers; }
        set { this.teachers = value; }
    }

    public string TextIdentifier
    {
        get { return this.textIdentifier; }
        set { this.textIdentifier = value; }
    }

    public string Comment
    {
        get { return this.comment; }
        set { this.comment = value; }
    }

    public SchoolClass(string textIdentifier)
    {
        this.TextIdentifier = textIdentifier;
        this.Teachers = new List<Teacher>();
        this.Comment = comment;
    }

    public void AddTeacher(Teacher teacher)
    {
        this.teachers.Add(teacher);
    }

    public void RemoveTeacher(Teacher teacher)
    {
        this.teachers.Remove(teacher);
    }

}
