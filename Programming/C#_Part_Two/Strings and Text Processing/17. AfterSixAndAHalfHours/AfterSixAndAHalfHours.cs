/*Task 17. Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
 and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.*/

using System;
using System.Globalization;
using System.Text;
using System.Threading;

class AfterSixAndAHalfHours
{
    static void Main()
    {

        Console.OutputEncoding = Encoding.Unicode;

        Console.Write("Enter date and time: ");
        string date = "30.11.2009 11:30:32";
        //string date = Console.Readline();

        CultureInfo provider = new CultureInfo("bg-BG");
        string format = "d.MM.yyyy HH:mm:ss";

        Thread.CurrentThread.CurrentCulture = provider;

        var result = DateTime.ParseExact(date, format, provider).AddMinutes(390);
        
        Console.WriteLine(@"Date and time after 6 hours 30 minutes: {0:d.MM.yyyy HH:mm:ss}, 
Day of  the week: {0:dddd}", result);

    }
}
