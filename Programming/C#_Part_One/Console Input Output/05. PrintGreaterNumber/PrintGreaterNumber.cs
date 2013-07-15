//Task 05. Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

class PrintGreaterNumber
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstValue = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int secondValue = int.Parse(Console.ReadLine());

        Console.WriteLine("The greater number is: {0}", ((firstValue + secondValue) + Math.Abs(firstValue - secondValue)) / 2);

        //Math.Max method can also be used:
        //Console.WriteLine("The greater number is: {0}", Math.Max(firstValue, secondValue));
    }
}

