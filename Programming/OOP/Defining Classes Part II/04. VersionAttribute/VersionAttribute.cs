using System;

[AttributeUsage(
AttributeTargets.Struct |
AttributeTargets.Class |
AttributeTargets.Interface |
AttributeTargets.Method |
AttributeTargets.Enum
)]
public class VersionAttribute : Attribute
{
    public int Major { get; set; }
    public int Minor { get; set; }

    public VersionAttribute(string version)
    {
        var splitted = version.Split('.');
        Major = int.Parse(splitted[0]);
        Minor = int.Parse(splitted[1]);
    }

    public override string ToString()
    {
        return string.Format("Version: {0}.{1}", Major, Minor);
    }
}
