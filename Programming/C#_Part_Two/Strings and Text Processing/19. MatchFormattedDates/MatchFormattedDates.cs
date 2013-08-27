/*Task 19. Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
Display them in the standard date format for Canada.*/

using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

class MatchFormattedDates
{
    static void Main()
    {
        string text = @"12.10.2011, 12/11/2011, 08.10.2012, 24 August 2013, 08-Nov-2003, Sunday, 8 November 2003,
8/xi/03, 8.xi.03, 8-xi.03, or 8.XI.200, 15.02.2004, 8/11/2003 or 08.11.2003 or 8-11-2003,November 9, 2003
Nov. 9, 2003 or 11/9/2003";

        string pattern = @"[0-9]+\.[0-9]+\.[0-9]+";
        Regex regex = new Regex(pattern);
        CultureInfo provider = new CultureInfo("en-CA");
        string format = "dd.MM.yyyy";

        Thread.CurrentThread.CurrentCulture = provider;

        MatchCollection datesMatchCollection = regex.Matches(text);

        foreach (var date in datesMatchCollection)
        {
            string temp = string.Empty;

            temp = date.ToString();
            var modified = DateTime.ParseExact(temp, format, provider);
            Console.WriteLine(modified);
        }

    }
}
