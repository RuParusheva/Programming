/*Task 16. Write a program that reads two dates in the format: day.month.year and calculates the number
 of days between them. Example:
Enter the first date: 27.02.2006
Enter the second date: 3.03.2004
Distance: 4 days*/

using System;
using System.Globalization;
using System.Threading;

class CalculateDays
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter the first date: ");
        string startDate = Console.ReadLine();
        //string startDate = "27.07.2006";
        Console.Write("Enter the second date: ");
        string endDate = Console.ReadLine();
        //string endDate = "3.03.2004";
        

        string format = "d.mm.yyyy";
        CultureInfo provider = CultureInfo.InvariantCulture;

        TimeSpan result = ((DateTime.ParseExact(endDate, format, provider))
                      - (DateTime.ParseExact(startDate, format, provider)));

        int difference = result.Days;
        Console.WriteLine("Distance: {0}", difference);

    }
}
