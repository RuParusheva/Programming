/*Task 05. Write a method that calculates the number of workdays between today and given date, passed as parameter. 
 Consider that workdays are all days from Monday to Friday except a fixed list of public holidays
 specified preliminary as array.*/

using System;
using System.Globalization;

class Workdays
{
    //This method gets the non-working Friday before Easter, also called Good Friday for a specific year of choice.
    //Easter is not taken into account, when counting workdays, because it is Sunday. 
    //If you would like to get Easter, modify the switch case to add 2 more days.
    //The method generates dates for Good Friday/Easter according to the Julian Calendar.
    static DateTime GoodFriday(DateTime endDate)
    {
        DateTime goodFriday = new DateTime();
        DateTime twentySecond = new DateTime(endDate.Year, 3, 22);

        int year = endDate.Year;

        int n1 = year % 19;
        int n2 = year % 4;
        int n3 = year % 7;
        int nA = (19 * n1) + 16;
        int n4 = nA % 30;
        int nB = (2 * n2) + (4 * n3) + (6 * n4);
        int n5 = nB % 7;
        int nC = n4 + n5;

        goodFriday = twentySecond.AddDays(nC);

        int day = (int)goodFriday.DayOfWeek;

        switch (day)
        {
            case 1:
                return goodFriday.AddDays(11);
            case 2:
                return goodFriday.AddDays(10);
            case 3:
                return goodFriday.AddDays(9);
            case 4:
                return goodFriday.AddDays(8);
            case 5:
                return goodFriday.AddDays(7);
            case 6:
                return goodFriday.AddDays(8);
            case 7:
                return goodFriday.AddDays(5);
            default:
                throw new ArgumentException("No such day of the week ");
        }
    }

    static bool IsHoliday(DateTime day, DateTime[] holidays)
    {
        foreach (DateTime holiday in holidays)
        {
            if (day == holiday)
            {
                return true;
            }
        }

        return false;
    }

    static int GetWorkingDays(DateTime today, DateTime endDate, DateTime goodFriday, DateTime[] holidays)
    {
        int workingDays = 0;

        while (today < endDate)
        {
            if (today.DayOfWeek != DayOfWeek.Saturday && today.DayOfWeek != DayOfWeek.Sunday
                && !IsHoliday(today, holidays) && today != goodFriday)
            {
                workingDays++;
            }
            today = today.AddDays(1);
        }

        return workingDays;
    }

    static void Main()
    {
        DateTime today = DateTime.Today;

        Console.Write("Enter date of interest (period end marker): ");
        var endDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

        DateTime goodFriday = GoodFriday(endDate);
        Console.WriteLine(goodFriday);

        //31-st of December is not included, as it is usually worked upfront at specific Saturday in December,
        //F.e. in 2012 this was 15.12.2012. For 2013 - 14.12.2013;
        DateTime[] bankHolidays = new DateTime[]
        {
            new DateTime(today.Year, 1, 1),
            new DateTime(today.Year, 3, 3),
            new DateTime(today.Year, 5, 1),
            new DateTime(today.Year, 5, 2),
            new DateTime(today.Year, 5, 6),
            new DateTime(today.Year, 5, 24),
            new DateTime(today.Year, 9, 6),
            new DateTime(today.Year, 9, 22),
            new DateTime(today.Year, 12, 24),
            new DateTime(today.Year, 12, 25),
            new DateTime(today.Year, 12, 26),
        };

        Console.WriteLine("Number of working days for this period: {0}",
            GetWorkingDays(today, endDate, goodFriday, bankHolidays));
    }
}
