/*Task 11. Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods
 and holds a version in the format major.minor (e.g. 2.11). Apply the version attribute to a sample class and display
 its version at runtime.*/

using System;
using System.Collections.Generic;

[Version("1.23")]
class Program
{
    static void Main()
    {
        var versionAttribute = (typeof(Program).GetCustomAttributes(typeof(VersionAttribute), false)[0] as VersionAttribute);
        var version = versionAttribute.ToString();

        Console.WriteLine("Major: {0}", versionAttribute.Major);
        Console.WriteLine("Minor: {0}", versionAttribute.Minor);
        Console.WriteLine(version);
    }
}
