//Second version of task 12 - Write a program to read your age from the console and print how old you will be after 10 years.

using System;

class MyAgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("What is my birth year?");
        int myBirthYear = int.Parse(Console.ReadLine());
        DateTime today = DateTime.Now;
        DateTime myFutureAge = today.AddYears(10);
        Console.WriteLine("My age is: {0}", (today.Year - myBirthYear));
        Console.WriteLine("After ten years I will be: {0} ", (myFutureAge.Year - myBirthYear));
    }
}