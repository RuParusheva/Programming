/*Task 01. Write a method that asks the user for his name and prints “Hello, <name>” 
(for example, “Hello, Peter!”). Write a program to test this method.*/

using System;

public class Program
{
    public static string GetGreeting(string name)
    {
        return string.Format("Hello, {0}!", name);
    }

    public static void Main()
    {
        Console.WriteLine("Enter your name: ");
        Console.WriteLine(GetGreeting(Console.ReadLine()));
    }
}
