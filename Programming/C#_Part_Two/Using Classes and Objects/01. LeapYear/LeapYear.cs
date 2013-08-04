//Task 01. Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;

class LeapYear
{
    static bool CheckLeap(int number)
    {
        bool isLeap = DateTime.IsLeapYear(number);

        return isLeap;
    }

    static void Main()
    {
        Console.WriteLine("Enter the year you would like to check: ");
        int yearToCheck = int.Parse(Console.ReadLine());

        Console.WriteLine("Is {0} leap? {1}", yearToCheck, CheckLeap(yearToCheck));
    }
}
