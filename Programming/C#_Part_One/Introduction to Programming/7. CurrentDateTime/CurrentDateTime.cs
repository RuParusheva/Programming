//Task 07. Create a console application that prints the current date and time.

using System;

class CurrentDateTime
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        string format = "F";                        //This line changes the date format only
        Console.WriteLine(now.ToString(format));
    }
}
