//Task 07. Using delegates write a class Timer that has can execute certain method at each t seconds.

using System;
using System.Timers;

internal class _Timer
{
    public static void Main()
    {
        var timer = new System.Timers.Timer(1000);
        timer.Elapsed += DisplayTime;
        timer.Enabled = true;

        Console.WriteLine("Press 'q' + 'enter' to quit.");
        while (Console.Read() != 'q')
        {
        }
    }

    private static void DisplayTime(object source, ElapsedEventArgs e)
    {
        Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
    }
}