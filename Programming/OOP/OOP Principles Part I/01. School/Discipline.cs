using System;
using System.Text;

public class Discipline
{
    private string discName;
    private ushort numberOfLectures;
    private ushort numberOfExercises;
    private string comment;

    public string DiscName
    {
        get { return this.discName; }
        set { this.discName = value; }
    }

    public ushort NumberOfLectures
    {
        get { return this.numberOfLectures; }
        set { this.numberOfLectures = value; }
    }

    public ushort NumberOfExercises
    {
        get { return this.numberOfExercises; }
        set { this.numberOfExercises = value; }
    }

    public string Comment
    {
        get { return this.comment; }
        set { this.comment = value; }
    }

    public Discipline(string discName, ushort numberOfLectures, ushort numberOfExercises)
        : this(discName, numberOfLectures, numberOfExercises, null)
    {
    }

    public Discipline(string discName, ushort numberOfLectures, ushort numberOfExercises, string comment)
    {
        this.DiscName = discName;
        this.NumberOfLectures = numberOfLectures;
        this.NumberOfExercises = numberOfExercises;
        this.Comment = comment;
    }

    public override string ToString()
    {
        StringBuilder info = new StringBuilder();
        info.AppendFormat("Discipline information: \n Name: {0} \n Lectures:{1} \n Exercises: {2} ",
            this.DiscName, this.NumberOfLectures, this.NumberOfExercises);

        if (Comment != null)
        {
            info.Append(Environment.NewLine);
            info.Append("Comments:");
            info.Append("\"");
            info.Append(Comment);
            info.Append("\"");
        }
        return info.ToString();
    }
}
