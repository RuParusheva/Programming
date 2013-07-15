//First version of task 12 - Write a program to read your age from the console and print how old you will be after 10 years.

using System;

class ReadAndPrintMyAge
{
    static void Main()
    {
        Console.WriteLine("What is my age?");
        int myAge = int.Parse(Console.ReadLine());
        Console.WriteLine("In ten years I will be: {0}", myAge + 10);
    }
}