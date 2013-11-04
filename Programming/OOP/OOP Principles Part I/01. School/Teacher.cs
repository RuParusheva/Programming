using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Teacher : Person
{
    private List<Discipline> disciplinesList = new List<Discipline>();

    public Teacher(string firstName, string lastName)
        : base(firstName, lastName)
    {
    }

    public Teacher(string firstName, string lastName, string comment)
        : base(firstName, lastName, comment)
    {
        Comment = comment;
    }

    public void AddDiscipline(Discipline discipline)
    {
        this.disciplinesList.Add(discipline);
    }

    public void RemoveDiscipline(Discipline discipline)
    {
        this.disciplinesList.Remove(discipline);
    }

    public List<Discipline> GetDisciplines()
    {
        return this.disciplinesList;
    }

    public override string ToString()
    {
        StringBuilder teacherInfo = new StringBuilder();
        teacherInfo.AppendLine("Teacher information: ");
        teacherInfo.AppendLine(base.ToString());
        teacherInfo.AppendLine("Disciplines taught:");
        teacherInfo.AppendLine(String.Join(Environment.NewLine, disciplinesList));
        return teacherInfo.ToString();
    }
}